using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbanco")]
    [Index(nameof(Rowguid), Name = "index_366624349", IsUnique = true)]
    public partial class Fbanco
    {
        [Key]
        [Column("id_banco")]
        [StringLength(4)]
        public string IdBanco { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(40)]
        public string RazonSocial { get; set; }
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
        [Column("calle")]
        [StringLength(30)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(8)]
        public string Numero { get; set; }
        [Column("colonia")]
        [StringLength(30)]
        public string Colonia { get; set; }
        [Column("cod_postal")]
        [StringLength(8)]
        public string CodPostal { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Required]
        [Column("numero_sucursal")]
        [StringLength(10)]
        public string NumeroSucursal { get; set; }
        [Required]
        [Column("descripcion_sucursal")]
        [StringLength(50)]
        public string DescripcionSucursal { get; set; }
        [Column("cve_shcp")]
        [StringLength(2)]
        public string CveShcp { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.Fbancos))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
    }
}
