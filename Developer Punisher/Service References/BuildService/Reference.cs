﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Developer_Punisher.BuildService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Build", Namespace="http://schemas.datacontract.org/2004/07/BuildFetcher")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Developer_Punisher.BuildService.BuildingBuild))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Developer_Punisher.BuildService.FailedBuild))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Developer_Punisher.BuildService.SuccessfullBuild))]
    public partial class Build : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BuildingBuild", Namespace="http://schemas.datacontract.org/2004/07/BuildFetcher")]
    [System.SerializableAttribute()]
    public partial class BuildingBuild : Developer_Punisher.BuildService.Build {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FailedBuild", Namespace="http://schemas.datacontract.org/2004/07/BuildFetcher")]
    [System.SerializableAttribute()]
    public partial class FailedBuild : Developer_Punisher.BuildService.Build {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SuccessfullBuild", Namespace="http://schemas.datacontract.org/2004/07/BuildFetcher")]
    [System.SerializableAttribute()]
    public partial class SuccessfullBuild : Developer_Punisher.BuildService.Build {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BuildService.IBuildFetcherService")]
    public interface IBuildFetcherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildFetcherService/GetCurrentBuild", ReplyAction="http://tempuri.org/IBuildFetcherService/GetCurrentBuildResponse")]
        Developer_Punisher.BuildService.Build GetCurrentBuild(string jobName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBuildFetcherService/GetBuild", ReplyAction="http://tempuri.org/IBuildFetcherService/GetBuildResponse")]
        Developer_Punisher.BuildService.Build GetBuild(string jobName, int buildnumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IBuildFetcherServiceChannel : Developer_Punisher.BuildService.IBuildFetcherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class BuildFetcherServiceClient : System.ServiceModel.ClientBase<Developer_Punisher.BuildService.IBuildFetcherService>, Developer_Punisher.BuildService.IBuildFetcherService {
        
        public BuildFetcherServiceClient() {
        }
        
        public BuildFetcherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BuildFetcherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BuildFetcherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BuildFetcherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Developer_Punisher.BuildService.Build GetCurrentBuild(string jobName) {
            return base.Channel.GetCurrentBuild(jobName);
        }
        
        public Developer_Punisher.BuildService.Build GetBuild(string jobName, int buildnumber) {
            return base.Channel.GetBuild(jobName, buildnumber);
        }
    }
}
