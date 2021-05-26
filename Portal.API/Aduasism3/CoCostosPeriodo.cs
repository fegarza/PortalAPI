using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_costos_periodo")]
    public partial class CoCostosPeriodo
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "numeric(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("cve_concepto", TypeName = "numeric(4, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("saldo_inicial", TypeName = "decimal(16, 2)")]
        public decimal? SaldoInicial { get; set; }
        [Column("movimientos_positivos", TypeName = "decimal(16, 2)")]
        public decimal MovimientosPositivos { get; set; }
        [Column("movimientos_negativos", TypeName = "decimal(16, 2)")]
        public decimal MovimientosNegativos { get; set; }
    }
}
