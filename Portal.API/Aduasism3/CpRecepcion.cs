using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cp_recepcion")]
    public partial class CpRecepcion
    {
        [Column("num_acuse", TypeName = "decimal(10, 0)")]
        public decimal NumAcuse { get; set; }
        [Required]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("numorden", TypeName = "decimal(6, 0)")]
        public decimal Numorden { get; set; }
        [Column("numrecepcion", TypeName = "decimal(6, 0)")]
        public decimal Numrecepcion { get; set; }
        [Column("cveproveedor", TypeName = "decimal(10, 0)")]
        public decimal? Cveproveedor { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(14, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("importe_total", TypeName = "decimal(16, 4)")]
        public decimal? ImporteTotal { get; set; }
        [Column("importe_iva", TypeName = "decimal(14, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("valor_descuento", TypeName = "decimal(14, 4)")]
        public decimal? ValorDescuento { get; set; }
        [Column("total", TypeName = "decimal(16, 4)")]
        public decimal? Total { get; set; }
        [Column("status", TypeName = "decimal(1, 0)")]
        public decimal? Status { get; set; }
    }
}
