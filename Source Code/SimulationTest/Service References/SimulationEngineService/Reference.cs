﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimulationTest.SimulationEngineService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/SimulationEngine")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimulationEngineService.ISimulationService")]
    public interface ISimulationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimulationService/GetData", ReplyAction="http://tempuri.org/ISimulationService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimulationService/GetData", ReplyAction="http://tempuri.org/ISimulationService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimulationService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ISimulationService/GetDataUsingDataContractResponse")]
        SimulationTest.SimulationEngineService.CompositeType GetDataUsingDataContract(SimulationTest.SimulationEngineService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimulationService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ISimulationService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<SimulationTest.SimulationEngineService.CompositeType> GetDataUsingDataContractAsync(SimulationTest.SimulationEngineService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimulationService/LoadProjectData", ReplyAction="http://tempuri.org/ISimulationService/LoadProjectDataResponse")]
        bool LoadProjectData(string modelConfig, string modelXML, string modelSimList, string languageManifest, string languageXML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimulationService/LoadProjectData", ReplyAction="http://tempuri.org/ISimulationService/LoadProjectDataResponse")]
        System.Threading.Tasks.Task<bool> LoadProjectDataAsync(string modelConfig, string modelXML, string modelSimList, string languageManifest, string languageXML);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimulationServiceChannel : global::SimulationTest.SimulationEngineService.ISimulationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimulationServiceClient : System.ServiceModel.ClientBase<global::SimulationTest.SimulationEngineService.ISimulationService>, global::SimulationTest.SimulationEngineService.ISimulationService {
        
        public SimulationServiceClient() {
        }
        
        public SimulationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimulationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimulationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimulationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public SimulationTest.SimulationEngineService.CompositeType GetDataUsingDataContract(SimulationTest.SimulationEngineService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<SimulationTest.SimulationEngineService.CompositeType> GetDataUsingDataContractAsync(SimulationTest.SimulationEngineService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool LoadProjectData(string modelConfig, string modelXML, string modelSimList, string languageManifest, string languageXML) {
            return base.Channel.LoadProjectData(modelConfig, modelXML, modelSimList, languageManifest, languageXML);
        }
        
        public System.Threading.Tasks.Task<bool> LoadProjectDataAsync(string modelConfig, string modelXML, string modelSimList, string languageManifest, string languageXML) {
            return base.Channel.LoadProjectDataAsync(modelConfig, modelXML, modelSimList, languageManifest, languageXML);
        }
    }
}