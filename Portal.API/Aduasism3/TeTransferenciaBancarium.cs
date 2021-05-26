using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_transferencia_bancaria")]
    public partial class TeTransferenciaBancarium
    {
        [Key]
        [Column("num_transferencia", TypeName = "numeric(6, 0)")]
        public decimal NumTransferencia { get; set; }
        [Key]
        [Column("numempresa_origen")]
        public int NumempresaOrigen { get; set; }
        [Key]
        [Column("num_banco_origen", TypeName = "numeric(2, 0)")]
        public decimal NumBancoOrigen { get; set; }
        [Key]
        [Column("num_cuenta_origen")]
        [StringLength(14)]
        public string NumCuentaOrigen { get; set; }
        [Key]
        [Column("numempresa_destino")]
        public int NumempresaDestino { get; set; }
        [Key]
        [Column("num_banco_destino", TypeName = "numeric(2, 0)")]
        public decimal NumBancoDestino { get; set; }
        [Key]
        [Column("num_cuenta_destino")]
        [StringLength(14)]
        public string NumCuentaDestino { get; set; }
        [Required]
        [Column("referencia")]
        [StringLength(40)]
        public string Referencia { get; set; }
        [Column("fecha_transferencia", TypeName = "datetime")]
        public DateTime FechaTransferencia { get; set; }
        [Required]
        [Column("moneda_origen")]
        [StringLength(5)]
        public string MonedaOrigen { get; set; }
        [Required]
        [Column("moneda_destino")]
        [StringLength(5)]
        public string MonedaDestino { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(10, 4)")]
        public decimal TipoCambio { get; set; }
        [Column("importe_transferencia", TypeName = "numeric(16, 4)")]
        public decimal ImporteTransferencia { get; set; }
        [Column("gastos", TypeName = "numeric(14, 4)")]
        public decimal Gastos { get; set; }
        [Column("comisiones", TypeName = "numeric(14, 4)")]
        public decimal Comisiones { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal ImporteIva { get; set; }
        [Column("importe_neto", TypeName = "numeric(16, 4)")]
        public decimal ImporteNeto { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal StatusContable { get; set; }
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
    }
}
