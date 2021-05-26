using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_cheque")]
    public partial class CpCheque
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_banco", TypeName = "decimal(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Key]
        [Column("num_docto_pago", TypeName = "decimal(10, 0)")]
        public decimal NumDoctoPago { get; set; }
        [Column("num_beneficiario", TypeName = "decimal(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Required]
        [Column("nombre_beneficiario")]
        [StringLength(50)]
        public string NombreBeneficiario { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Column("status_cheque", TypeName = "decimal(1, 0)")]
        public decimal StatusCheque { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("fecha_cheque", TypeName = "datetime")]
        public DateTime? FechaCheque { get; set; }
        [Column("valor_total", TypeName = "decimal(16, 4)")]
        public decimal ValorTotal { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(14, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_beneficiario", TypeName = "decimal(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("num_banco_destino")]
        [StringLength(60)]
        public string NumBancoDestino { get; set; }
        [Column("num_cuenta_destino")]
        [StringLength(30)]
        public string NumCuentaDestino { get; set; }
        [Column("tipo_cheque")]
        [StringLength(1)]
        public string TipoCheque { get; set; }
        [Key]
        [Column("clasificacion")]
        [StringLength(1)]
        public string Clasificacion { get; set; }
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
        [Column("status_contab_cancelacion", TypeName = "decimal(1, 0)")]
        public decimal? StatusContabCancelacion { get; set; }
        [Column("fecha_contab_cancelacion", TypeName = "datetime")]
        public DateTime? FechaContabCancelacion { get; set; }
        [Column("poliza_contab_cancelacion", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContabCancelacion { get; set; }
        [Column("periodo_contab_cancelacion", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContabCancelacion { get; set; }
        [Column("movimiento_contab_cancelacion", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContabCancelacion { get; set; }
        [Column("leyenda")]
        [StringLength(40)]
        public string Leyenda { get; set; }
        [Column("invoice_number")]
        [StringLength(30)]
        public string InvoiceNumber { get; set; }
        [Column("import_tmsf")]
        public bool? ImportTmsf { get; set; }
    }
}
