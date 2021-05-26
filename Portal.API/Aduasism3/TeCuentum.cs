using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_cuenta")]
    public partial class TeCuentum
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Column("tipo_cuenta", TypeName = "numeric(3, 0)")]
        public decimal? TipoCuenta { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("status_cuenta", TypeName = "numeric(1, 0)")]
        public decimal? StatusCuenta { get; set; }
        [Column("saldo_cuenta", TypeName = "numeric(16, 4)")]
        public decimal? SaldoCuenta { get; set; }
        [Column("saldo_banco", TypeName = "numeric(16, 4)")]
        public decimal? SaldoBanco { get; set; }
        [Column("saldo_periodo", TypeName = "numeric(16, 4)")]
        public decimal? SaldoPeriodo { get; set; }
        [StringLength(50)]
        public string CtaBeneficiario { get; set; }
    }
}
