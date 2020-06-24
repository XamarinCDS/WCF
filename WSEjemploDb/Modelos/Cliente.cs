namespace WSEjemploDb.Modelos
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [DataMember]
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [DataMember]
        [StringLength(50)]
        public string Direccion { get; set; }
        [DataMember]
        [StringLength(9)]
        public string Telefono { get; set; }
    }
}
