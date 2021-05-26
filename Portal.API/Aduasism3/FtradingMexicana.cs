using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftrading_mexicana")]
    public partial class FtradingMexicana
    {
        [Key]
        [Column("n_factura")]
        [StringLength(8)]
        public string NFactura { get; set; }
        [Column("cve_clie")]
        [StringLength(4)]
        public string CveClie { get; set; }
        [Column("fec_cuenta", TypeName = "datetime")]
        public DateTime? FecCuenta { get; set; }
        [Column("referencia")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Column("rectificacion")]
        public int? Rectificacion { get; set; }
        [Column("regimen")]
        [StringLength(3)]
        public string Regimen { get; set; }
        [Column("num_pdto")]
        [StringLength(12)]
        public string NumPdto { get; set; }
        [Column("n_facturas")]
        [StringLength(12)]
        public string NFacturas { get; set; }
        [Column("valor_fac", TypeName = "numeric(11, 2)")]
        public decimal? ValorFac { get; set; }
        [Column("peso_merc", TypeName = "numeric(11, 2)")]
        public decimal? PesoMerc { get; set; }
        [Column("gast_compr", TypeName = "numeric(11, 2)")]
        public decimal? GastCompr { get; set; }
        [Column("impuestos", TypeName = "numeric(11, 2)")]
        public decimal? Impuestos { get; set; }
        [Column("otros", TypeName = "numeric(11, 2)")]
        public decimal? Otros { get; set; }
        [Column("cruce", TypeName = "numeric(11, 2)")]
        public decimal? Cruce { get; set; }
        [Column("todogasto", TypeName = "numeric(11, 2)")]
        public decimal? Todogasto { get; set; }
        [Column("flete", TypeName = "numeric(11, 2)")]
        public decimal? Flete { get; set; }
        [Column("maniobras", TypeName = "numeric(11, 2)")]
        public decimal? Maniobras { get; set; }
        [Column("etiquetado", TypeName = "numeric(11, 2)")]
        public decimal? Etiquetado { get; set; }
        [Column("valor_nor", TypeName = "numeric(11, 2)")]
        public decimal? ValorNor { get; set; }
        [Column("honorarios", TypeName = "numeric(11, 2)")]
        public decimal? Honorarios { get; set; }
        [Column("anticipo", TypeName = "numeric(11, 2)")]
        public decimal? Anticipo { get; set; }
        [Column("iva", TypeName = "numeric(11, 2)")]
        public decimal? Iva { get; set; }
        [Column("imp_dls", TypeName = "numeric(11, 2)")]
        public decimal? ImpDls { get; set; }
        [Column("tip_cambio", TypeName = "numeric(4, 2)")]
        public decimal? TipCambio { get; set; }
        [Column("n_ctaamer")]
        [StringLength(10)]
        public string NCtaamer { get; set; }
        [Column("sucursal")]
        [StringLength(3)]
        public string Sucursal { get; set; }
        [Column("totaliva", TypeName = "numeric(11, 2)")]
        public decimal? Totaliva { get; set; }
        [Column("ivaagente", TypeName = "numeric(11, 2)")]
        public decimal? Ivaagente { get; set; }
        [Column("ivaped", TypeName = "numeric(11, 2)")]
        public decimal? Ivaped { get; set; }
        [Column("ivaotros", TypeName = "numeric(11, 2)")]
        public decimal? Ivaotros { get; set; }
        [Column("cuenta")]
        public int? Cuenta { get; set; }
        [Column("total", TypeName = "numeric(12, 2)")]
        public decimal? Total { get; set; }
    }
}
