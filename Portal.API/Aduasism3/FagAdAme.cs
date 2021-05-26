using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fag_ad_ame")]
    [Index(nameof(Rowguid), Name = "index_1828917587", IsUnique = true)]
    public partial class FagAdAme
    {
        public FagAdAme()
        {
            OcEmbarques = new HashSet<OcEmbarque>();
        }

        [Key]
        [Column("ID_AG_AD_AME")]
        [StringLength(6)]
        public string IdAgAdAme { get; set; }
        [Required]
        [Column("NOMBRE")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [Column("AP_PATERNO")]
        [StringLength(25)]
        public string ApPaterno { get; set; }
        [Column("AP_MATERNO")]
        [StringLength(25)]
        public string ApMaterno { get; set; }
        [Column("IRS")]
        [StringLength(20)]
        public string Irs { get; set; }
        [Column("TITULO")]
        [StringLength(4)]
        public string Titulo { get; set; }
        [Column("CVE_TELEFONO")]
        [StringLength(5)]
        public string CveTelefono { get; set; }
        [Column("FAX")]
        [StringLength(7)]
        public string Fax { get; set; }
        [Column("correo_electronico")]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [Column("telefono1")]
        [StringLength(7)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(7)]
        public string Telefono2 { get; set; }
        [Column("telefono3")]
        [StringLength(7)]
        public string Telefono3 { get; set; }
        [Column("telefono4")]
        [StringLength(7)]
        public string Telefono4 { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Required]
        [Column("numero")]
        [StringLength(8)]
        public string Numero { get; set; }
        [Required]
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Column("codigo_postal")]
        [StringLength(8)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modificacion", TypeName = "datetime")]
        public DateTime FechaUltModificacion { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.FagAdAmes))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.FagAdAmes))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
        [InverseProperty(nameof(OcEmbarque.IdAgAdAmeNavigation))]
        public virtual ICollection<OcEmbarque> OcEmbarques { get; set; }
    }
}
