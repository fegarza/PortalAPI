using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_det_log_costos")]
    public partial class CoDetLogCosto
    {
        [Key]
        [Column("consecutivo_movimiento", TypeName = "numeric(10, 0)")]
        public decimal ConsecutivoMovimiento { get; set; }
        [Key]
        [Column("cve_concepto", TypeName = "numeric(4, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("valor_afectacion", TypeName = "decimal(16, 2)")]
        public decimal ValorAfectacion { get; set; }
    }
}
