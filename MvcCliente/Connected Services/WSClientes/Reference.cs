﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCliente.WSClientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WSEjemploDb.Modelos")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
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
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSClientes.IClientes")]
    public interface IClientes {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/GetClientes", ReplyAction="http://tempuri.org/IClientes/GetClientesResponse")]
        MvcCliente.WSClientes.Cliente[] GetClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/GetClientes", ReplyAction="http://tempuri.org/IClientes/GetClientesResponse")]
        System.Threading.Tasks.Task<MvcCliente.WSClientes.Cliente[]> GetClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/GetCliente", ReplyAction="http://tempuri.org/IClientes/GetClienteResponse")]
        MvcCliente.WSClientes.Cliente GetCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientes/GetCliente", ReplyAction="http://tempuri.org/IClientes/GetClienteResponse")]
        System.Threading.Tasks.Task<MvcCliente.WSClientes.Cliente> GetClienteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientesChannel : MvcCliente.WSClientes.IClientes, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesClient : System.ServiceModel.ClientBase<MvcCliente.WSClientes.IClientes>, MvcCliente.WSClientes.IClientes {
        
        public ClientesClient() {
        }
        
        public ClientesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MvcCliente.WSClientes.Cliente[] GetClientes() {
            return base.Channel.GetClientes();
        }
        
        public System.Threading.Tasks.Task<MvcCliente.WSClientes.Cliente[]> GetClientesAsync() {
            return base.Channel.GetClientesAsync();
        }
        
        public MvcCliente.WSClientes.Cliente GetCliente(int id) {
            return base.Channel.GetCliente(id);
        }
        
        public System.Threading.Tasks.Task<MvcCliente.WSClientes.Cliente> GetClienteAsync(int id) {
            return base.Channel.GetClienteAsync(id);
        }
    }
}