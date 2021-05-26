using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_escape")]
    [Index(nameof(Rowguid), Name = "index_1870629707", IsUnique = true)]
    public partial class FclienteEscape
    {
        [Key]
        [Column("id_escape")]
        public int IdEscape { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("consignatario")]
        [StringLength(50)]
        public string Consignatario { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("estacion")]
        [StringLength(50)]
        public string Estacion { get; set; }
        [Column("domicilio")]
        [StringLength(40)]
        public string Domicilio { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("clave")]
        [StringLength(6)]
        public string Clave { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Fcliente.FclienteEscapes))]
        public virtual Fcliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.FclienteEscapes))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
    }
}
