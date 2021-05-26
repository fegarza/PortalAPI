using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("flinea_fletera")]
    [Index(nameof(Rowguid), Name = "index_1278627598", IsUnique = true)]
    public partial class FlineaFletera
    {
        public FlineaFletera()
        {
            Fembarque1s = new HashSet<Fembarque1>();
        }

        [Key]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
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
        [Required]
        [Column("cve_tipo_linea")]
        [StringLength(1)]
        public string CveTipoLinea { get; set; }
        [Column("cve_tipo_transporte")]
        [StringLength(2)]
        public string CveTipoTransporte { get; set; }
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
        [Column("dias_libres", TypeName = "numeric(2, 0)")]
        public decimal? DiasLibres { get; set; }
        [Column("importe_demora_dia", TypeName = "numeric(9, 2)")]
        public decimal? ImporteDemoraDia { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("id_tipo_flete")]
        [StringLength(1)]
        public string IdTipoFlete { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("CAAT")]
        [StringLength(6)]
        public string Caat { get; set; }
        [Column("transfer_scac")]
        [StringLength(4)]
        public string TransferScac { get; set; }
        [Column("ident_transporte")]
        [StringLength(17)]
        public string IdentTransporte { get; set; }
        [Column("pais")]
        [StringLength(3)]
        public string Pais { get; set; }
        [Column("carrier_code")]
        [StringLength(10)]
        public string CarrierCode { get; set; }
        [Column("ct_pat")]
        [StringLength(1)]
        public string CtPat { get; set; }
        [Column("verificado_por")]
        [StringLength(1)]
        public string VerificadoPor { get; set; }
        [Column("paqueteria")]
        public bool Paqueteria { get; set; }
        [Column("id_estado")]
        [StringLength(4)]
        public string IdEstado { get; set; }
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
        [Column("linea_fast")]
        [StringLength(1)]
        public string LineaFast { get; set; }

        [ForeignKey(nameof(IdMunicipio))]
        [InverseProperty(nameof(Fmunicipio.FlineaFleteras))]
        public virtual Fmunicipio IdMunicipioNavigation { get; set; }
        [ForeignKey(nameof(IdUsuarioRegistro))]
        [InverseProperty(nameof(Fusuario.FlineaFleteras))]
        public virtual Fusuario IdUsuarioRegistroNavigation { get; set; }
        [InverseProperty(nameof(Fembarque1.IdLineaFleteraNavigation))]
        public virtual ICollection<Fembarque1> Fembarque1s { get; set; }
    }
}
