using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_trafico")]
    [Index(nameof(IdTrafico), Name = "Indx_fpedimento_trafico_id_trafico")]
    [Index(nameof(Rowguid), Name = "index_539864990", IsUnique = true)]
    public partial class FpedimentoTrafico
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("referencia_secuencial", TypeName = "numeric(3, 0)")]
        public decimal ReferenciaSecuencial { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("trafico_secuencial", TypeName = "numeric(4, 0)")]
        public decimal TraficoSecuencial { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(18, 3)")]
        public decimal? CantidadComercial { get; set; }
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? Importe { get; set; }
        [Column("id_producto_factura")]
        [StringLength(20)]
        public string IdProductoFactura { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
    }
}
