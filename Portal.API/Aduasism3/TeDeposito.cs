using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_deposito")]
    public partial class TeDeposito
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
        [Key]
        [Column("num_deposito", TypeName = "numeric(6, 0)")]
        public decimal NumDeposito { get; set; }
        [Required]
        [Column("referencia")]
        [StringLength(40)]
        public string Referencia { get; set; }
        [Column("fecha_deposito", TypeName = "datetime")]
        public DateTime FechaDeposito { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(10, 4)")]
        public decimal TipoCambio { get; set; }
        [Column("total_efectivo", TypeName = "numeric(16, 4)")]
        public decimal TotalEfectivo { get; set; }
        [Column("total_cheques", TypeName = "numeric(16, 4)")]
        public decimal TotalCheques { get; set; }
        [Column("total_deposito", TypeName = "numeric(16, 4)")]
        public decimal TotalDeposito { get; set; }
        [Column("status_deposito", TypeName = "numeric(1, 0)")]
        public decimal StatusDeposito { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal StatusContable { get; set; }
    }
}
