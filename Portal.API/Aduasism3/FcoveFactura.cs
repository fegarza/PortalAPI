using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_facturas")]
    public partial class FcoveFactura
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("identificador", TypeName = "numeric(9, 0)")]
        public decimal Identificador { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("em_tax_id")]
        [StringLength(50)]
        public string EmTaxId { get; set; }
        [Column("em_rfc")]
        [StringLength(13)]
        public string EmRfc { get; set; }
        [Column("em_curp")]
        [StringLength(18)]
        public string EmCurp { get; set; }
        [Column("em_tipo_identificador")]
        [StringLength(1)]
        public string EmTipoIdentificador { get; set; }
        [Column("em_apellido_paterno")]
        [StringLength(200)]
        public string EmApellidoPaterno { get; set; }
        [Column("em_apellido_materno")]
        [StringLength(200)]
        public string EmApellidoMaterno { get; set; }
        [Column("em_nombre")]
        [StringLength(200)]
        public string EmNombre { get; set; }
        [Column("em_calle")]
        [StringLength(100)]
        public string EmCalle { get; set; }
        [Column("em_num_ext")]
        [StringLength(55)]
        public string EmNumExt { get; set; }
        [Column("em_num_int")]
        [StringLength(55)]
        public string EmNumInt { get; set; }
        [Column("em_colonia")]
        [StringLength(120)]
        public string EmColonia { get; set; }
        [Column("em_localidad")]
        [StringLength(120)]
        public string EmLocalidad { get; set; }
        [Column("em_referencia")]
        [StringLength(250)]
        public string EmReferencia { get; set; }
        [Column("em_municipio")]
        [StringLength(120)]
        public string EmMunicipio { get; set; }
        [Column("em_estado")]
        [StringLength(30)]
        public string EmEstado { get; set; }
        [Column("em_pais")]
        [StringLength(120)]
        public string EmPais { get; set; }
        [Column("em_codigo_postal")]
        [StringLength(12)]
        public string EmCodigoPostal { get; set; }
        [Column("tipo_identificador_dest")]
        [StringLength(1)]
        public string TipoIdentificadorDest { get; set; }
        [Column("tax_id")]
        [StringLength(50)]
        public string TaxId { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("des_apellido_paterno")]
        [StringLength(200)]
        public string DesApellidoPaterno { get; set; }
        [Column("des_apellido_materno")]
        [StringLength(200)]
        public string DesApellidoMaterno { get; set; }
        [Column("des_nombre")]
        [StringLength(200)]
        public string DesNombre { get; set; }
        [Column("des_calle")]
        [StringLength(100)]
        public string DesCalle { get; set; }
        [Column("des_numero_exterior")]
        [StringLength(55)]
        public string DesNumeroExterior { get; set; }
        [Column("des_numero_interior")]
        [StringLength(55)]
        public string DesNumeroInterior { get; set; }
        [Column("des_colonia")]
        [StringLength(120)]
        public string DesColonia { get; set; }
        [Column("des_localidad")]
        [StringLength(120)]
        public string DesLocalidad { get; set; }
        [Column("des_referencia")]
        [StringLength(250)]
        public string DesReferencia { get; set; }
        [Column("des_municipio")]
        [StringLength(120)]
        public string DesMunicipio { get; set; }
        [Column("des_estado")]
        [StringLength(30)]
        public string DesEstado { get; set; }
        [Column("des_pais")]
        [StringLength(120)]
        public string DesPais { get; set; }
        [Column("des_codigo_postal")]
        [StringLength(12)]
        public string DesCodigoPostal { get; set; }
    }
}
