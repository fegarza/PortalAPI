using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_dfactura_mex")]
    public partial class FfgDfacturaMex
    {
        [Key]
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Key]
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
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
        [Column("precio", TypeName = "numeric(12, 2)")]
        public decimal? Precio { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal? Cantidad { get; set; }
        [Column("monto", TypeName = "numeric(12, 2)")]
        public decimal? Monto { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("agrupa_concepto")]
        [StringLength(1)]
        public string AgrupaConcepto { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("monto_comisionista", TypeName = "decimal(18, 0)")]
        public decimal? MontoComisionista { get; set; }
        [Column("monto_corresponsal", TypeName = "decimal(18, 0)")]
        public decimal? MontoCorresponsal { get; set; }
        [Column("porcentaje_comisionista", TypeName = "decimal(18, 0)")]
        public decimal? PorcentajeComisionista { get; set; }
        [Column("porcentaje_corresponsal", TypeName = "decimal(18, 0)")]
        public decimal? PorcentajeCorresponsal { get; set; }
        [Column("costo_venta", TypeName = "decimal(18, 0)")]
        public decimal? CostoVenta { get; set; }
        [Column("utilidad", TypeName = "decimal(18, 0)")]
        public decimal? Utilidad { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("monto_porcentaje", TypeName = "numeric(12, 2)")]
        public decimal? MontoPorcentaje { get; set; }
        [Column("monto_dlls", TypeName = "decimal(14, 2)")]
        public decimal? MontoDlls { get; set; }
        [Column("c_ClaveProdServ")]
        [StringLength(8)]
        public string CClaveProdServ { get; set; }
        [Column("c_ClaveUnidad")]
        [StringLength(3)]
        public string CClaveUnidad { get; set; }
        [StringLength(250)]
        public string UnidadDescripcion { get; set; }
        [Column(TypeName = "numeric(14, 2)")]
        public decimal? Descuento { get; set; }
    }
}
