using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fag_ad_mex")]
    [Index(nameof(Rowguid), Name = "index_1860917701", IsUnique = true)]
    public partial class FagAdMex
    {
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        [Column("ap_paterno")]
        [StringLength(25)]
        public string ApPaterno { get; set; }
        [Required]
        [Column("ap_materno")]
        [StringLength(25)]
        public string ApMaterno { get; set; }
        [Required]
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("titulo")]
        [StringLength(13)]
        public string Titulo { get; set; }
        [Column("cve_telefono")]
        [StringLength(5)]
        public string CveTelefono { get; set; }
        [Column("fax")]
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
        [Column("cve_tipo_patente")]
        [StringLength(1)]
        public string CveTipoPatente { get; set; }
        [Required]
        [Column("registro")]
        [StringLength(4)]
        public string Registro { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_ult_modificacion", TypeName = "datetime")]
        public DateTime FechaUltModificacion { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("password")]
        [StringLength(10)]
        public string Password { get; set; }
        [Column("num_serie")]
        [StringLength(30)]
        public string NumSerie { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("firma")]
        [StringLength(250)]
        public string Firma { get; set; }
        [Column("archivo_cer")]
        [StringLength(250)]
        public string ArchivoCer { get; set; }
        [Column("archivo_key")]
        [StringLength(250)]
        public string ArchivoKey { get; set; }
        [Column("passw_fea")]
        [StringLength(20)]
        public string PasswFea { get; set; }
        [Column("archivo_bat")]
        [StringLength(150)]
        public string ArchivoBat { get; set; }
        [Column("archivos_firmar")]
        [StringLength(150)]
        public string ArchivosFirmar { get; set; }
        [Column("ruta_xml")]
        [StringLength(250)]
        public string RutaXml { get; set; }
        [Column("contrasena_web")]
        [StringLength(100)]
        public string ContrasenaWeb { get; set; }
        [Column("ruta_key")]
        [StringLength(250)]
        public string RutaKey { get; set; }
        [Column("contrasena_key")]
        [StringLength(50)]
        public string ContrasenaKey { get; set; }
        [Column("ruta_cer")]
        [StringLength(250)]
        public string RutaCer { get; set; }
        [Required]
        [Column("cer_vencimiento")]
        [StringLength(1)]
        public string CerVencimiento { get; set; }
        [Column("cer_vencimiento_fecha", TypeName = "datetime")]
        public DateTime? CerVencimientoFecha { get; set; }
        [Column("sha256")]
        [StringLength(1)]
        public string Sha256 { get; set; }
        [Column("ruta_xml_portal")]
        [StringLength(250)]
        public string RutaXmlPortal { get; set; }
        [Column("SCC")]
        [StringLength(6)]
        public string Scc { get; set; }
        [Column("contrasena_ciec")]
        [StringLength(100)]
        public string ContrasenaCiec { get; set; }
        [Column("ruta_xml_doda")]
        [StringLength(250)]
        public string RutaXmlDoda { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.FagAdMices))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
    }
}
