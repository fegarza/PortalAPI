using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproveedores")]
    public partial class Fproveedore
    {
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
        [Required]
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(10)]
        public string Numero { get; set; }
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
    }
}
