using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_estimacion")]
    public partial class CpEstimacion
    {
        [Key]
        [Column("num_estimacion", TypeName = "decimal(3, 0)")]
        public decimal NumEstimacion { get; set; }
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("num_contrato", TypeName = "decimal(8, 0)")]
        public decimal NumContrato { get; set; }
        [Column("cve_contratista", TypeName = "decimal(10, 0)")]
        public decimal CveContratista { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(16, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("importe_estimacion", TypeName = "decimal(16, 4)")]
        public decimal? ImporteEstimacion { get; set; }
        [Column("importe_iva", TypeName = "decimal(16, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("importe_amortizacion", TypeName = "decimal(16, 4)")]
        public decimal? ImporteAmortizacion { get; set; }
        [Column("importe_fondo_garantia", TypeName = "decimal(16, 4)")]
        public decimal? ImporteFondoGarantia { get; set; }
        [Column("saldo_estimacion", TypeName = "decimal(16, 4)")]
        public decimal? SaldoEstimacion { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
