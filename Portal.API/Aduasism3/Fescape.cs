using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fescape")]
    [Index(nameof(Rowguid), Name = "index_2094630505", IsUnique = true)]
    public partial class Fescape
    {
        [Key]
        [Column("id_escape")]
        [StringLength(6)]
        public string IdEscape { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("estacion")]
        [StringLength(50)]
        public string Estacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("consignatario")]
        [StringLength(48)]
        public string Consignatario { get; set; }
        [Column("rfc_consignatario")]
        [StringLength(13)]
        public string RfcConsignatario { get; set; }
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(8)]
        public string Numero { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("remitente_de_consignatario")]
        [StringLength(48)]
        public string RemitenteDeConsignatario { get; set; }
        [Column("domicilio_rem_consignatario")]
        [StringLength(40)]
        public string DomicilioRemConsignatario { get; set; }
        [Column("telefono_reg_consig")]
        [StringLength(20)]
        public string TelefonoRegConsig { get; set; }
        [Column("fin_rem_consig")]
        [StringLength(40)]
        public string FinRemConsig { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Fcliente.Fescapes))]
        public virtual Fcliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.Fescapes))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
    }
}
