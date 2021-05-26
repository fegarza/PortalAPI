using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_recibo_ingreso")]
    public partial class TeReciboIngreso
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(6, 0)")]
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
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiario { get; set; }
        [Column("cve_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal CveBeneficiario { get; set; }
        [Column("cve_cpto_ingreso", TypeName = "numeric(3, 0)")]
        public decimal CveCptoIngreso { get; set; }
        [Column("valor_efectivo", TypeName = "numeric(16, 4)")]
        public decimal ValorEfectivo { get; set; }
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
    }
}
