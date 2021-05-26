using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_recibo_ingreso_ad")]
    public partial class TeReciboIngresoAd
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(10, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Column("fecha_registro_recibo_ingreso", TypeName = "datetime")]
        public DateTime FechaRegistroReciboIngreso { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Required]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(10, 4)")]
        public decimal TipoCambio { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal StatusContable { get; set; }
        [Column("valor_cobro", TypeName = "numeric(16, 4)")]
        public decimal ValorCobro { get; set; }
        [Column("fecha_contabilizacion", TypeName = "datetime")]
        public DateTime FechaContabilizacion { get; set; }
        [Column("num_deposito", TypeName = "numeric(6, 0)")]
        public decimal NumDeposito { get; set; }
        [Column("valor_doctos", TypeName = "numeric(16, 4)")]
        public decimal? ValorDoctos { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("consecutivo_cuenta", TypeName = "numeric(9, 0)")]
        public decimal? ConsecutivoCuenta { get; set; }
    }
}
