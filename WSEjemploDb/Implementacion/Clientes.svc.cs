using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSEjemploDb.Modelos;

namespace WSEjemploDb.Implementacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Clientes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Clientes.svc o Clientes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Clientes : IClientes
    {
        Model1 db = new Model1();

        public string Add(Cliente item)
        {
            db.Cliente.Add(item);
            return "Agregado";
        }

        public Cliente GetCliente(int id)
        {
            return db.Cliente.Find(id);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return db.Cliente;
        }
    }
}
