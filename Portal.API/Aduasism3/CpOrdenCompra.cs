using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_orden_compra")]
    public partial class CpOrdenCompra
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("numorden", TypeName = "decimal(6, 0)")]
        public decimal Numorden { get; set; }
        [Column("cveproveedor", TypeName = "decimal(10, 0)")]
        public decimal Cveproveedor { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(14, 4)")]
        public decimal TipoCambio { get; set; }
        [Column("importe_iva", TypeName = "decimal(14, 4)")]
        public decimal ImporteIva { get; set; }
        [Column("valor_descuento", TypeName = "decimal(16, 4)")]
        public decimal ValorDescuento { get; set; }
        [Column("importe_total", TypeName = "decimal(16, 4)")]
        public decimal? ImporteTotal { get; set; }
        [Column("saldo_orden", TypeName = "decimal(16, 4)")]
        public decimal SaldoOrden { get; set; }
        [Column("status", TypeName = "decimal(1, 0)")]
        public decimal? Status { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("dias_credito")]
        public int DiasCredito { get; set; }
        [Column("por_anticipo", TypeName = "decimal(5, 2)")]
        public decimal PorAnticipo { get; set; }
        [Column("saldo_anticipo", TypeName = "decimal(16, 4)")]
        public decimal? SaldoAnticipo { get; set; }
        [Column("importe_actual_anticipo", TypeName = "decimal(16, 4)")]
        public decimal? ImporteActualAnticipo { get; set; }
    }
}
