using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WSPersonas.Models
{
    public class Persona
    {
        
        public int IdPersona { get; set; }
        [DataMember]//Si esto no se escribe no se mostraria la propiedad al cliente
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
        [DataMember]
        public int Edad { get; set; }
    }
}