using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_recepcion")]
    public partial class CmRecepcion
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("numorden", TypeName = "decimal(6, 0)")]
        public decimal Numorden { get; set; }
        [Key]
        [Column("numrecepcion", TypeName = "decimal(6, 0)")]
        public decimal Numrecepcion { get; set; }
        [Column("fecha_recepcion", TypeName = "datetime")]
        public DateTime FechaRecepcion { get; set; }
        [Column("num_acuse", TypeName = "decimal(10, 0)")]
        public decimal? NumAcuse { get; set; }
        [Column("sol_inspeccion")]
        [StringLength(20)]
        public string SolInspeccion { get; set; }
        [Column("rep_inspeccion")]
        [StringLength(20)]
        public string RepInspeccion { get; set; }
        [Column("remision")]
        [StringLength(20)]
        public string Remision { get; set; }
        [Column("factura", TypeName = "decimal(6, 0)")]
        public decimal? Factura { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("tipo_recepcion")]
        public int? TipoRecepcion { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("notas")]
        [StringLength(255)]
        public string Notas { get; set; }
        [Column("cveproveedor", TypeName = "decimal(10, 0)")]
        public decimal? Cveproveedor { get; set; }
        [Column("empresa", TypeName = "decimal(6, 0)")]
        public decimal? Empresa { get; set; }
        [Column("iva", TypeName = "decimal(5, 2)")]
        public decimal? Iva { get; set; }
        [Column("desc_global", TypeName = "decimal(6, 2)")]
        public decimal? DescGlobal { get; set; }
        [Column("imptotal", TypeName = "decimal(14, 2)")]
        public decimal? Imptotal { get; set; }
        [Column("total", TypeName = "decimal(16, 4)")]
        public decimal? Total { get; set; }
        [Column("num_almacen")]
        [StringLength(8)]
        public string NumAlmacen { get; set; }
        [Column("localizacion_fisica")]
        [StringLength(60)]
        public string LocalizacionFisica { get; set; }
        [Column("cveembarque", TypeName = "decimal(3, 0)")]
        public decimal? Cveembarque { get; set; }
        [Column("cve_almacenista")]
        [StringLength(10)]
        public string CveAlmacenista { get; set; }
        [Column("fechaorden", TypeName = "datetime")]
        public DateTime? Fechaorden { get; set; }
    }
}
