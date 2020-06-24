using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSPersonas.Models;

namespace WSPersonas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISPersonas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISPersonas
    {
        [OperationContract]
        Persona GetPersona(int id);
        [OperationContract]
        IEnumerable<Persona> GetPersonas();
        [OperationContract]
        string Add(Persona item);
    }
}
