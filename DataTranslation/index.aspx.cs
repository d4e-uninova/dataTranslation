using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTranslation
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender,EventArgs e)
        {
            newFile.Visible = FileUpload1.HasFile;
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    byte[] uploadedFile;
                    string guid = Guid.NewGuid().ToString();
                    string path = Server.MapPath("~") + "\\files\\";
                    path = path.Replace("\\\\", "\\");
                    DataExchange.ServiceDataFormat inputFormat = 0;
                    DataExchange.ServiceDataFormat outputFormat = 0;
                    string outFile = "";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    switch (InputFormatSelector.SelectedValue)
                    {
                        case "IFC":
                            inputFormat = DataExchange.ServiceDataFormat.IFC;
                            break;
                        case "RVT":
                            inputFormat = DataExchange.ServiceDataFormat.RVT;
                            break;
                        case "gbXML":
                            inputFormat = DataExchange.ServiceDataFormat.gbXML;
                            break;
                        case "IDF":
                            inputFormat = DataExchange.ServiceDataFormat.IDF;
                            break;

                    }
                    switch (OutputFormatSelector.SelectedValue)
                    {
                        case "IFC":
                            outputFormat = DataExchange.ServiceDataFormat.IFC;
                            outFile = path + Path.ChangeExtension(FileUpload1.FileName, "ifc");
                            break;
                        case "RVT":
                            outputFormat = DataExchange.ServiceDataFormat.RVT;
                            outFile = path + Path.ChangeExtension(FileUpload1.FileName, "rvt");
                            break;
                        case "gbXML":
                            outputFormat = DataExchange.ServiceDataFormat.gbXML;
                            outFile = path + Path.ChangeExtension(FileUpload1.FileName, "xml");
                            break;
                        case "IDF":
                            outputFormat = DataExchange.ServiceDataFormat.IDF;
                            outFile = path + Path.ChangeExtension(FileUpload1.FileName, "idf");
                            break;

                    }
                    uploadedFile = FileUpload1.FileBytes;
                    outFile = getFileName(outFile);
                    Global.logger.log("Conversion of \""+FileUpload1.FileName+"\" from "+inputFormat+" to "+outputFormat+" requested by: "+Request.UserHostAddress);
                    translateAsync(uploadedFile, inputFormat, outputFormat, outFile,Request.UserHostAddress);

                }
            }
            catch(Exception ex)
            {
                Global.logger.log(ex.Message, Logger.LogType.ERROR);
            }
            
        }
        private string getFileName(string outFile)
        {
            string tmpPath="";
            int maxFileCount = 1000;
            if(File.Exists(outFile) ||Global.fileNames.ContainsValue(outFile))
            {
                for(var i=1;i<maxFileCount;i++)
                {
                    tmpPath = Path.GetDirectoryName(outFile) + "\\" + Path.GetFileNameWithoutExtension(outFile) + "_"+i + Path.GetExtension(outFile);
                    if (!File.Exists(tmpPath) && !Global.fileNames.ContainsValue(tmpPath))
                    {
                        return tmpPath;
                    }
                }
                File.Delete(tmpPath);
                return tmpPath;
            }
            return outFile;
        }


        private void translateAsync(byte[] uploadedFile, DataExchange.ServiceDataFormat inputFormat, DataExchange.ServiceDataFormat outputFormat, string outFile,string address)
        {
            try
            {
                DataExchange.DataTranslationClient client = new DataExchange.DataTranslationClient();
                IAsyncResult asyncResult = client.Begintranslate(new DataExchange.ServiceTranslationInfo
                   {
                       Data = uploadedFile,
                       InputFormat = inputFormat,
                       OutputFormat = outputFormat
                   }, callback, client);
                Global.fileNames.Add(asyncResult.AsyncWaitHandle.SafeWaitHandle, outFile);
                Global.addresses.Add(asyncResult.AsyncWaitHandle.SafeWaitHandle, address);
                Global.clients.Add(asyncResult.AsyncWaitHandle.SafeWaitHandle, client);
            }
            catch (Exception ex)
            {
                Global.logger.log(ex.Message, Logger.LogType.ERROR);
            }
        }

        private void callback(IAsyncResult asyncResult)
        {
            try
            {
                string path = Global.fileNames[asyncResult.AsyncWaitHandle.SafeWaitHandle];
                string address = Global.addresses[asyncResult.AsyncWaitHandle.SafeWaitHandle];
                DataExchange.DataTranslationClient client = Global.clients[asyncResult.AsyncWaitHandle.SafeWaitHandle];
                DataExchange.ServiceTranslationResult result = client.Endtranslate(asyncResult);
                if (result.Succeeded)
                {
                    File.WriteAllBytes(path, result.Data);
                    Global.logger.log("Writing file: \"" + path+"\"");
                    Global.logger.log("Conversion requested by: " + address + " succeeded");
                }
                else
                {
                    Global.logger.log("Conversion requested by: " + address + " failed",Logger.LogType.ERROR);
                }
                client.Close();
                Global.fileNames.Remove(asyncResult.AsyncWaitHandle.SafeWaitHandle);
                Global.addresses.Remove(asyncResult.AsyncWaitHandle.SafeWaitHandle);
                Global.clients.Remove(asyncResult.AsyncWaitHandle.SafeWaitHandle);
            }
            catch(Exception ex)
            {
                Global.logger.log(ex.Message, Logger.LogType.ERROR);
            }
        }
    }
}