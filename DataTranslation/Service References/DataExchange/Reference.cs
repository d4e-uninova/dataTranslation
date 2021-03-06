﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTranslation.DataExchange {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service.TranslationInfo", Namespace="http://schemas.datacontract.org/2004/07/DataExchangeSolution")]
    [System.SerializableAttribute()]
    public partial struct ServiceTranslationInfo : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DataTranslation.DataExchange.ServiceDataFormat InputFormatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DataTranslation.DataExchange.ServiceDataFormat OutputFormatField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DataTranslation.DataExchange.ServiceDataFormat InputFormat {
            get {
                return this.InputFormatField;
            }
            set {
                if ((this.InputFormatField.Equals(value) != true)) {
                    this.InputFormatField = value;
                    this.RaisePropertyChanged("InputFormat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DataTranslation.DataExchange.ServiceDataFormat OutputFormat {
            get {
                return this.OutputFormatField;
            }
            set {
                if ((this.OutputFormatField.Equals(value) != true)) {
                    this.OutputFormatField = value;
                    this.RaisePropertyChanged("OutputFormat");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service.DataFormat", Namespace="http://schemas.datacontract.org/2004/07/DataExchangeSolution")]
    public enum ServiceDataFormat : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IFC = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gbXML = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RVT = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IDF = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service.TranslationResult", Namespace="http://schemas.datacontract.org/2004/07/DataExchangeSolution")]
    [System.SerializableAttribute()]
    public partial struct ServiceTranslationResult : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucceededField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Succeeded {
            get {
                return this.SucceededField;
            }
            set {
                if ((this.SucceededField.Equals(value) != true)) {
                    this.SucceededField = value;
                    this.RaisePropertyChanged("Succeeded");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service.SimulationInfo", Namespace="http://schemas.datacontract.org/2004/07/DataExchangeSolution")]
    [System.SerializableAttribute()]
    public partial struct ServiceSimulationInfo : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DataTranslation.DataExchange.ServiceDataFormat ModelFormatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DataTranslation.DataExchange.ServiceSimulationType TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] WeatherDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DataTranslation.DataExchange.ServiceDataFormat ModelFormat {
            get {
                return this.ModelFormatField;
            }
            set {
                if ((this.ModelFormatField.Equals(value) != true)) {
                    this.ModelFormatField = value;
                    this.RaisePropertyChanged("ModelFormat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DataTranslation.DataExchange.ServiceSimulationType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] WeatherData {
            get {
                return this.WeatherDataField;
            }
            set {
                if ((object.ReferenceEquals(this.WeatherDataField, value) != true)) {
                    this.WeatherDataField = value;
                    this.RaisePropertyChanged("WeatherData");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service.SimulationType", Namespace="http://schemas.datacontract.org/2004/07/DataExchangeSolution")]
    public enum ServiceSimulationType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Energetic = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service.SimulationResult", Namespace="http://schemas.datacontract.org/2004/07/DataExchangeSolution")]
    [System.SerializableAttribute()]
    public partial struct ServiceSimulationResult : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucceededField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Succeeded {
            get {
                return this.SucceededField;
            }
            set {
                if ((this.SucceededField.Equals(value) != true)) {
                    this.SucceededField = value;
                    this.RaisePropertyChanged("Succeeded");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataExchange.IDataTranslation")]
    public interface IDataTranslation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataTranslation/translate", ReplyAction="http://tempuri.org/IDataTranslation/translateResponse")]
        DataTranslation.DataExchange.ServiceTranslationResult translate(DataTranslation.DataExchange.ServiceTranslationInfo info);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDataTranslation/translate", ReplyAction="http://tempuri.org/IDataTranslation/translateResponse")]
        System.IAsyncResult Begintranslate(DataTranslation.DataExchange.ServiceTranslationInfo info, System.AsyncCallback callback, object asyncState);
        
        DataTranslation.DataExchange.ServiceTranslationResult Endtranslate(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataTranslationChannel : DataTranslation.DataExchange.IDataTranslation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class translateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public translateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public DataTranslation.DataExchange.ServiceTranslationResult Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((DataTranslation.DataExchange.ServiceTranslationResult)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataTranslationClient : System.ServiceModel.ClientBase<DataTranslation.DataExchange.IDataTranslation>, DataTranslation.DataExchange.IDataTranslation {
        
        private BeginOperationDelegate onBegintranslateDelegate;
        
        private EndOperationDelegate onEndtranslateDelegate;
        
        private System.Threading.SendOrPostCallback ontranslateCompletedDelegate;
        
        public DataTranslationClient() {
        }
        
        public DataTranslationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataTranslationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataTranslationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataTranslationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<translateCompletedEventArgs> translateCompleted;
        
        public DataTranslation.DataExchange.ServiceTranslationResult translate(DataTranslation.DataExchange.ServiceTranslationInfo info) {
            return base.Channel.translate(info);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Begintranslate(DataTranslation.DataExchange.ServiceTranslationInfo info, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Begintranslate(info, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public DataTranslation.DataExchange.ServiceTranslationResult Endtranslate(System.IAsyncResult result) {
            return base.Channel.Endtranslate(result);
        }
        
        private System.IAsyncResult OnBegintranslate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            DataTranslation.DataExchange.ServiceTranslationInfo info = ((DataTranslation.DataExchange.ServiceTranslationInfo)(inValues[0]));
            return this.Begintranslate(info, callback, asyncState);
        }
        
        private object[] OnEndtranslate(System.IAsyncResult result) {
            DataTranslation.DataExchange.ServiceTranslationResult retVal = this.Endtranslate(result);
            return new object[] {
                    retVal};
        }
        
        private void OntranslateCompleted(object state) {
            if ((this.translateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.translateCompleted(this, new translateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void translateAsync(DataTranslation.DataExchange.ServiceTranslationInfo info) {
            this.translateAsync(info, null);
        }
        
        public void translateAsync(DataTranslation.DataExchange.ServiceTranslationInfo info, object userState) {
            if ((this.onBegintranslateDelegate == null)) {
                this.onBegintranslateDelegate = new BeginOperationDelegate(this.OnBegintranslate);
            }
            if ((this.onEndtranslateDelegate == null)) {
                this.onEndtranslateDelegate = new EndOperationDelegate(this.OnEndtranslate);
            }
            if ((this.ontranslateCompletedDelegate == null)) {
                this.ontranslateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OntranslateCompleted);
            }
            base.InvokeAsync(this.onBegintranslateDelegate, new object[] {
                        info}, this.onEndtranslateDelegate, this.ontranslateCompletedDelegate, userState);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataExchange.IDataSimulation")]
    public interface IDataSimulation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataSimulation/simulate", ReplyAction="http://tempuri.org/IDataSimulation/simulateResponse")]
        DataTranslation.DataExchange.ServiceSimulationResult simulate(DataTranslation.DataExchange.ServiceSimulationInfo info);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDataSimulation/simulate", ReplyAction="http://tempuri.org/IDataSimulation/simulateResponse")]
        System.IAsyncResult Beginsimulate(DataTranslation.DataExchange.ServiceSimulationInfo info, System.AsyncCallback callback, object asyncState);
        
        DataTranslation.DataExchange.ServiceSimulationResult Endsimulate(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataSimulationChannel : DataTranslation.DataExchange.IDataSimulation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class simulateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public simulateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public DataTranslation.DataExchange.ServiceSimulationResult Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((DataTranslation.DataExchange.ServiceSimulationResult)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataSimulationClient : System.ServiceModel.ClientBase<DataTranslation.DataExchange.IDataSimulation>, DataTranslation.DataExchange.IDataSimulation {
        
        private BeginOperationDelegate onBeginsimulateDelegate;
        
        private EndOperationDelegate onEndsimulateDelegate;
        
        private System.Threading.SendOrPostCallback onsimulateCompletedDelegate;
        
        public DataSimulationClient() {
        }
        
        public DataSimulationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataSimulationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataSimulationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataSimulationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<simulateCompletedEventArgs> simulateCompleted;
        
        public DataTranslation.DataExchange.ServiceSimulationResult simulate(DataTranslation.DataExchange.ServiceSimulationInfo info) {
            return base.Channel.simulate(info);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginsimulate(DataTranslation.DataExchange.ServiceSimulationInfo info, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginsimulate(info, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public DataTranslation.DataExchange.ServiceSimulationResult Endsimulate(System.IAsyncResult result) {
            return base.Channel.Endsimulate(result);
        }
        
        private System.IAsyncResult OnBeginsimulate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            DataTranslation.DataExchange.ServiceSimulationInfo info = ((DataTranslation.DataExchange.ServiceSimulationInfo)(inValues[0]));
            return this.Beginsimulate(info, callback, asyncState);
        }
        
        private object[] OnEndsimulate(System.IAsyncResult result) {
            DataTranslation.DataExchange.ServiceSimulationResult retVal = this.Endsimulate(result);
            return new object[] {
                    retVal};
        }
        
        private void OnsimulateCompleted(object state) {
            if ((this.simulateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.simulateCompleted(this, new simulateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void simulateAsync(DataTranslation.DataExchange.ServiceSimulationInfo info) {
            this.simulateAsync(info, null);
        }
        
        public void simulateAsync(DataTranslation.DataExchange.ServiceSimulationInfo info, object userState) {
            if ((this.onBeginsimulateDelegate == null)) {
                this.onBeginsimulateDelegate = new BeginOperationDelegate(this.OnBeginsimulate);
            }
            if ((this.onEndsimulateDelegate == null)) {
                this.onEndsimulateDelegate = new EndOperationDelegate(this.OnEndsimulate);
            }
            if ((this.onsimulateCompletedDelegate == null)) {
                this.onsimulateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnsimulateCompleted);
            }
            base.InvokeAsync(this.onBeginsimulateDelegate, new object[] {
                        info}, this.onEndsimulateDelegate, this.onsimulateCompletedDelegate, userState);
        }
    }
}
