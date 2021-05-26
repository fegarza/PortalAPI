using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FPROVEEDOR_INTERNO")]
    [Index(nameof(Rowguid), Name = "index_606625204", IsUnique = true)]
    public partial class FproveedorInterno
    {
        [Key]
        [Column("ID_PROVEEDOR")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(40)]
        public string RazonSocial { get; set; }
        [Required]
        [Column("razon_social_abreviada")]
        [StringLength(10)]
        public string RazonSocialAbreviada { get; set; }
        [Required]
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Required]
        [Column("cve_telefono")]
        [StringLength(10)]
        public string CveTelefono { get; set; }
        [Required]
        [Column("fax")]
        [StringLength(7)]
        public string Fax { get; set; }
        [Required]
        [Column("correo_electronico")]
        [StringLength(20)]
        public string CorreoElectronico { get; set; }
        [Required]
        [Column("tel1")]
        [StringLength(7)]
        public string Tel1 { get; set; }
        [Required]
        [Column("tel2")]
        [StringLength(7)]
        public string Tel2 { get; set; }
        [Required]
        [Column("tel3")]
        [StringLength(7)]
        public string Tel3 { get; set; }
        [Required]
        [Column("tel4")]
        [StringLength(7)]
        public string Tel4 { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Required]
        [Column("numero")]
        [StringLength(6)]
        public string Numero { get; set; }
        [Required]
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Required]
        [Column("codigo_postal")]
        [StringLength(8)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("municipio")]
        [StringLength(4)]
        public string Municipio { get; set; }
        [Required]
        [Column("IRS")]
        [StringLength(20)]
        public string Irs { get; set; }
        [Required]
        [Column("CVE_TIPO_FACTURA")]
        [StringLength(4)]
        public string CveTipoFactura { get; set; }
        [Required]
        [Column("cta_contable")]
        [StringLength(12)]
        public string CtaContable { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.FproveedorInternoIdUsuarioRegistroNavigations))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioUltmodif))]
        [InverseProperty(nameof(Fusuario.FproveedorInternoIdUsuarioUltmodifNavigations))]
        public virtual Fusuario IdUsuarioUltmodifNavigation { get; set; }
        [ForeignKey(nameof(Municipio))]
        [InverseProperty(nameof(Fmunicipio.FproveedorInternos))]
        public virtual Fmunicipio MunicipioNavigation { get; set; }
    }
}
