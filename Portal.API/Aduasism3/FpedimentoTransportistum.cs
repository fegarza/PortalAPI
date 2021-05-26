using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_transportista")]
    [Index(nameof(Rowguid), Name = "index_1588916732", IsUnique = true)]
    public partial class FpedimentoTransportistum
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Required]
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
        [Key]
        [Column("iden_transporte")]
        [StringLength(17)]
        public string IdenTransporte { get; set; }
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
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("apoderado_trans")]
        [StringLength(6)]
        public string ApoderadoTrans { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("total_bultos", TypeName = "decimal(5, 0)")]
        public decimal? TotalBultos { get; set; }
        [Column("domicilio_fiscal")]
        [StringLength(150)]
        public string DomicilioFiscal { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("registro")]
        [StringLength(20)]
        public string Registro { get; set; }
    }
}
