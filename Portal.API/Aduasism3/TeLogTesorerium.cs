using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_log_tesoreria")]
    public partial class TeLogTesorerium
    {
        [Key]
        [Column("tipo_movto", TypeName = "numeric(3, 0)")]
        public decimal TipoMovto { get; set; }
        [Key]
        [Column("num_movto", TypeName = "numeric(10, 0)")]
        public decimal NumMovto { get; set; }
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
        [Required]
        [Column("referencia")]
        [StringLength(40)]
        public string Referencia { get; set; }
        [Key]
        [Column("fecha_movto", TypeName = "datetime")]
        public DateTime FechaMovto { get; set; }
        [Column("tipo_afectacion", TypeName = "numeric(1, 0)")]
        public decimal TipoAfectacion { get; set; }
        [Column("importe_movto", TypeName = "numeric(16, 4)")]
        public decimal ImporteMovto { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(10, 4)")]
        public decimal TipoCambio { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("conciliado")]
        [StringLength(1)]
        public string Conciliado { get; set; }
        [Column("fecha_banco", TypeName = "datetime")]
        public DateTime? FechaBanco { get; set; }
    }
}
