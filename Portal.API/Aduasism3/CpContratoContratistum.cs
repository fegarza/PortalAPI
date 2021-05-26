using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_contrato_contratista")]
    public partial class CpContratoContratistum
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("num_contrato", TypeName = "decimal(8, 0)")]
        public decimal NumContrato { get; set; }
        [Column("num_anticipo", TypeName = "decimal(3, 0)")]
        public decimal NumAnticipo { get; set; }
        [Column("cve_contratista", TypeName = "decimal(10, 0)")]
        public decimal CveContratista { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(16, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("saldo_anticipo", TypeName = "decimal(16, 4)")]
        public decimal? SaldoAnticipo { get; set; }
        [Column("status", TypeName = "decimal(1, 0)")]
        public decimal? Status { get; set; }
    }
}
