<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Async="true" Inherits="DataTranslation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="icon" href="favicon.ico" />
    <link rel="stylesheet" href="lib/bootstrap-3.3.5/css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/main.css" />
    <script type="text/javascript" src="lib/jquery-2.1.4/jquery-2.1.4.min.js" ></script>
    <script type="text/javascript" src="lib/bootstrap-3.3.5/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/main.js" ></script>
    <title>Data Translation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="small-nav">
            <nav class="navbar navbar-default navbar-fixed-top">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-top" aria-expanded="false" aria-controls="navbar">
						    <span class="sr-only">Toggle navigation</span>
						    <span class="icon-bar"></span>
						    <span class="icon-bar"></span>
						    <span class="icon-bar"></span>
					    </button>
                        <img class="navbar-img" src="images/logo.png" />
                    </div>
                    <div id="navbar-top" class="navbar-collapse collapse">
                        <ul class="nav navbar-nav">
                            <li><a href="../datatranslation"><b>Data Translation</b></a></li>
                            <li><a href="../datasimulation"><b>Data Simulation</b></a></li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
        <br /><br />
    
        <div class="small-container">
            <div class="container">
              <div class="header clearfix">
                 <h3 class="text-muted">Data Translation</h3>
              </div>

              <div class="jumbotron">
                <b>Input Format</b>
                <br />
                <asp:DropDownList ID="InputFormatSelector" runat="server">
                    <asp:ListItem>IFC</asp:ListItem>
                    <asp:ListItem>RVT</asp:ListItem>
                    <asp:ListItem>gbXML</asp:ListItem>
                    <asp:ListItem>IDF</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <b>Output format</b>
                <br />
                <asp:DropDownList ID="OutputFormatSelector" runat="server">
                    <asp:ListItem>IFC</asp:ListItem>
                    <asp:ListItem>RVT</asp:ListItem>
                    <asp:ListItem>gbXML</asp:ListItem>
                    <asp:ListItem>IDF</asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br /><br />
                <asp:Button ID="Upload" runat="server" Text="Convert" OnClick="Upload_Click" />


                <br />
                <br />
                <asp:Label ID="newFile" runat="server" Visible="false">
                    <b>Translation in progress...</b>
                    <br />
                    <br />
                </asp:Label>
                <b>Translated files:</b>
                <br />
                <br />
                <div id="links">
                </div>
              </div>        

            </div> 
         </div>

    </form>
</body>
</html>
