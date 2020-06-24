using System.Collections.Generic;
using System.ServiceModel;
using WSEjemploDb.Modelos;

namespace WSEjemploDb.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientes
    {
        [OperationContract]
        IEnumerable<Cliente> GetClientes();
        [OperationContract]
        Cliente GetCliente(int id);
        [OperationContract]
        string Add(Cliente item);
    }
}
