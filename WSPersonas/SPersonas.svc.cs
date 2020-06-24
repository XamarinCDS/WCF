using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSPersonas.Models;

namespace WSPersonas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "SPersonas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione SPersonas.svc o SPersonas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SPersonas : ISPersonas
    {
        private List<Persona> personas = new List<Persona>();
        public SPersonas()
        {
            Add(new Persona { IdPersona = 1, Nombre = "Joel", Apellido = "Moran", Edad = 20 });
            Add(new Persona { IdPersona = 2, Nombre = "Daniel", Apellido = "Moran", Edad = 18 });
            Add(new Persona { IdPersona = 3, Nombre = "Samuel", Apellido = "Guardado", Edad = 16 });
        }

        public Persona GetPersona(int id)
        {
            return personas.Find(p => p.IdPersona == id);
        }

        public string Add(Persona item)
        {
            personas.Add(item);
            return "Agregado";
        }

        public IEnumerable<Persona> GetPersonas()
        {
            return personas;
        }

       
    }
}
