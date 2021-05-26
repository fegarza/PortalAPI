using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_cheque_cancelado")]
    public partial class CpChequeCancelado
    {
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Key]
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal NumDoctoPago { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("status_cheque", TypeName = "numeric(1, 0)")]
        public decimal StatusCheque { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("fecha_cheque", TypeName = "datetime")]
        public DateTime? FechaCheque { get; set; }
        [Column("valor_total", TypeName = "numeric(16, 4)")]
        public decimal ValorTotal { get; set; }
        [Column("referencia")]
        [StringLength(60)]
        public string Referencia { get; set; }
        [Required]
        [Column("nombre_beneficiario")]
        [StringLength(50)]
        public string NombreBeneficiario { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(14, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_beneficiario", TypeName = "decimal(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("fecha_cancelacion", TypeName = "datetime")]
        public DateTime? FechaCancelacion { get; set; }
    }
}
