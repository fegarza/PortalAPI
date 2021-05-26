using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_control_pago_peca")]
    public partial class FfgControlPagoPeca
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        [StringLength(10)]
        public string IdRectificacion { get; set; }
        [Key]
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Required]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(1, 0)")]
        public decimal CveComprobable { get; set; }
        [Column("id_unidad_facturacion")]
        [StringLength(4)]
        public string IdUnidadFacturacion { get; set; }
        [Column("precio", TypeName = "decimal(12, 2)")]
        public decimal? Precio { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal? Cantidad { get; set; }
        [Column("monto", TypeName = "numeric(12, 2)")]
        public decimal? Monto { get; set; }
        [Required]
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Required]
        [Column("id_precuenta")]
        [StringLength(10)]
        public string IdPrecuenta { get; set; }
    }
}
