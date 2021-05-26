using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_ferrocarril")]
    public partial class FpedimentoFerrocarril
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("referencia_secuencial", TypeName = "numeric(3, 0)")]
        public decimal ReferenciaSecuencial { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("ferrocarril_secuencial", TypeName = "numeric(4, 0)")]
        public decimal FerrocarrilSecuencial { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("importe", TypeName = "decimal(12, 2)")]
        public decimal? Importe { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(18, 3)")]
        public decimal? CantidadComercial { get; set; }
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
    }
}
