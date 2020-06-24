﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCliente.SRPersona {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/WSPersonas.Models")]
    [System.SerializableAttribute()]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPersonaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPersona {
            get {
                return this.IdPersonaField;
            }
            set {
                if ((this.IdPersonaField.Equals(value) != true)) {
                    this.IdPersonaField = value;
                    this.RaisePropertyChanged("IdPersona");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRPersona.ISPersonas")]
    public interface ISPersonas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISPersonas/GetPersona", ReplyAction="http://tempuri.org/ISPersonas/GetPersonaResponse")]
        MvcCliente.SRPersona.Persona GetPersona(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISPersonas/GetPersona", ReplyAction="http://tempuri.org/ISPersonas/GetPersonaResponse")]
        System.Threading.Tasks.Task<MvcCliente.SRPersona.Persona> GetPersonaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISPersonas/GetPersonas", ReplyAction="http://tempuri.org/ISPersonas/GetPersonasResponse")]
        MvcCliente.SRPersona.Persona[] GetPersonas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISPersonas/GetPersonas", ReplyAction="http://tempuri.org/ISPersonas/GetPersonasResponse")]
        System.Threading.Tasks.Task<MvcCliente.SRPersona.Persona[]> GetPersonasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISPersonas/Add", ReplyAction="http://tempuri.org/ISPersonas/AddResponse")]
        string Add(MvcCliente.SRPersona.Persona item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISPersonas/Add", ReplyAction="http://tempuri.org/ISPersonas/AddResponse")]
        System.Threading.Tasks.Task<string> AddAsync(MvcCliente.SRPersona.Persona item);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISPersonasChannel : MvcCliente.SRPersona.ISPersonas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SPersonasClient : System.ServiceModel.ClientBase<MvcCliente.SRPersona.ISPersonas>, MvcCliente.SRPersona.ISPersonas {
        
        public SPersonasClient() {
        }
        
        public SPersonasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SPersonasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SPersonasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SPersonasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MvcCliente.SRPersona.Persona GetPersona(int id) {
            return base.Channel.GetPersona(id);
        }
        
        public System.Threading.Tasks.Task<MvcCliente.SRPersona.Persona> GetPersonaAsync(int id) {
            return base.Channel.GetPersonaAsync(id);
        }
        
        public MvcCliente.SRPersona.Persona[] GetPersonas() {
            return base.Channel.GetPersonas();
        }
        
        public System.Threading.Tasks.Task<MvcCliente.SRPersona.Persona[]> GetPersonasAsync() {
            return base.Channel.GetPersonasAsync();
        }
        
        public string Add(MvcCliente.SRPersona.Persona item) {
            return base.Channel.Add(item);
        }
        
        public System.Threading.Tasks.Task<string> AddAsync(MvcCliente.SRPersona.Persona item) {
            return base.Channel.AddAsync(item);
        }
    }
}