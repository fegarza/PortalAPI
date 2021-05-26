using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbodega")]
    public partial class Fbodega
    {
        [Key]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(40)]
        public string RazonSocial { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("cve_telefono")]
        [StringLength(10)]
        public string CveTelefono { get; set; }
        [Column("fax")]
        [StringLength(7)]
        public string Fax { get; set; }
        [Column("correo_electronico")]
        [StringLength(200)]
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
        [Column("codigo_postal")]
        [StringLength(8)]
        public string CodigoPostal { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("id_usuario_responsable")]
        [StringLength(6)]
        public string IdUsuarioResponsable { get; set; }
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
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("candado_bodega")]
        [StringLength(1)]
        public string CandadoBodega { get; set; }
        [Column("shipper_inbond")]
        public bool? ShipperInbond { get; set; }
        [Column("inbond_code")]
        [StringLength(2)]
        public string InbondCode { get; set; }
        [Column("foreign_trade_zone")]
        [StringLength(7)]
        public string ForeignTradeZone { get; set; }
        [Column("candado_bultos_trafico")]
        [StringLength(1)]
        public string CandadoBultosTrafico { get; set; }
        [Column("corresponsal")]
        public bool? Corresponsal { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Column("sello")]
        public bool Sello { get; set; }
        [Column("medio_transporte_default")]
        [StringLength(2)]
        public string MedioTransporteDefault { get; set; }
        [Column("peso_por_guia")]
        public bool? PesoPorGuia { get; set; }

        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.FbodegaIdUsuarioRegistroNavigations))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioResponsable))]
        [InverseProperty(nameof(Fusuario.FbodegaIdUsuarioResponsableNavigations))]
        public virtual Fusuario IdUsuarioResponsableNavigation { get; set; }
    }
}
