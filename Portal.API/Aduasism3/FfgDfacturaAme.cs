using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_dfactura_ame")]
    public partial class FfgDfacturaAme
    {
        [Required]
        [Column("id_factura_ame")]
        [StringLength(10)]
        public string IdFacturaAme { get; set; }
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Required]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(1, 0)")]
        public decimal CveComprobable { get; set; }
        [Column("id_unidad_facturacion")]
        [StringLength(4)]
        public string IdUnidadFacturacion { get; set; }
        [Column("precio", TypeName = "decimal(12, 4)")]
        public decimal? Precio { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal? Cantidad { get; set; }
        [Column("monto", TypeName = "numeric(12, 2)")]
        public decimal? Monto { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Column("agrupa_concepto")]
        [StringLength(1)]
        public string AgrupaConcepto { get; set; }
    }
}
