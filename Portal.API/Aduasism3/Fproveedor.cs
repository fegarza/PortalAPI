using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproveedor")]
    [Index(nameof(Rowguid), Name = "index_257435991", IsUnique = true)]
    public partial class Fproveedor
    {
        public Fproveedor()
        {
            Fdtraficos = new HashSet<Fdtrafico>();
            Fgfacturas = new HashSet<Fgfactura>();
            FrelClienteProveedors = new HashSet<FrelClienteProveedor>();
        }

        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Required]
        [Column("razon_social_abreviada")]
        [StringLength(10)]
        public string RazonSocialAbreviada { get; set; }
        [Column("cve_telefono")]
        [StringLength(10)]
        public string CveTelefono { get; set; }
        [Column("fax")]
        [StringLength(15)]
        public string Fax { get; set; }
        [Column("correo_electronico")]
        [StringLength(20)]
        public string CorreoElectronico { get; set; }
        [Column("tel1")]
        [StringLength(15)]
        public string Tel1 { get; set; }
        [Column("tel2")]
        [StringLength(15)]
        public string Tel2 { get; set; }
        [Column("tel3")]
        [StringLength(15)]
        public string Tel3 { get; set; }
        [Column("tel4")]
        [StringLength(15)]
        public string Tel4 { get; set; }
        [Column("calle")]
        [StringLength(120)]
        public string Calle { get; set; }
        [Required]
        [Column("numero")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("colonia")]
        [StringLength(60)]
        public string Colonia { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("IRS")]
        [StringLength(20)]
        public string Irs { get; set; }
        [Required]
        [Column("id_cuenta_contable")]
        [StringLength(12)]
        public string IdCuentaContable { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_referencia")]
        [StringLength(20)]
        public string IdReferencia { get; set; }
        [Column("domicilio_logo")]
        [StringLength(250)]
        public string DomicilioLogo { get; set; }
        [Column("razons_logo")]
        [StringLength(250)]
        public string RazonsLogo { get; set; }
        [Column("routed_exp_transact_ind")]
        [StringLength(1)]
        public string RoutedExpTransactInd { get; set; }
        [Column("contact_first_name")]
        [StringLength(13)]
        public string ContactFirstName { get; set; }
        [Column("contact_last_name")]
        [StringLength(20)]
        public string ContactLastName { get; set; }
        [Column("usppi")]
        public bool? Usppi { get; set; }
        [Column("num_export_confiable")]
        [StringLength(50)]
        public string NumExportConfiable { get; set; }
        [Column("localidad")]
        [StringLength(120)]
        public string Localidad { get; set; }
        [Column("num_oracle")]
        [StringLength(10)]
        public string NumOracle { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.Fproveedors))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.Fproveedors))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
        [InverseProperty(nameof(Fdtrafico.IdProveedorNavigation))]
        public virtual ICollection<Fdtrafico> Fdtraficos { get; set; }
        [InverseProperty(nameof(Fgfactura.IdProveedorNavigation))]
        public virtual ICollection<Fgfactura> Fgfacturas { get; set; }
        [InverseProperty(nameof(FrelClienteProveedor.IdProveedorNavigation))]
        public virtual ICollection<FrelClienteProveedor> FrelClienteProveedors { get; set; }
    }
}
