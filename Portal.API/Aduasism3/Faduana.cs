using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faduana")]
    [Index(nameof(Rowguid), Name = "index_686625489", IsUnique = true)]
    public partial class Faduana
    {
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(40)]
        public string RazonSocial { get; set; }
        [Required]
        [Column("razon_social_abreviada")]
        [StringLength(13)]
        public string RazonSocialAbreviada { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("cve_telefono")]
        [StringLength(5)]
        public string CveTelefono { get; set; }
        [Column("fax")]
        [StringLength(7)]
        public string Fax { get; set; }
        [Column("correo_electronico")]
        [StringLength(20)]
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
        [Column("cod_postal")]
        [StringLength(8)]
        public string CodPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("cve_tipo_aduana")]
        [StringLength(1)]
        public string CveTipoAduana { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("cve_prevalidador")]
        [StringLength(5)]
        public string CvePrevalidador { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("siglas_aaa")]
        [StringLength(10)]
        public string SiglasAaa { get; set; }
        [Column("ruta_subir_fact_elect_pc")]
        [StringLength(100)]
        public string RutaSubirFactElectPc { get; set; }
        [Column("descripcion_oficial")]
        [StringLength(150)]
        public string DescripcionOficial { get; set; }
        [Column("restriccion_horario")]
        [StringLength(1)]
        public string RestriccionHorario { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.Faduanas))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
    }
}
