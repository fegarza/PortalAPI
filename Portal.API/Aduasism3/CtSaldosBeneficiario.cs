using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_saldos_beneficiarios")]
    public partial class CtSaldosBeneficiario
    {
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("num_cuenta", TypeName = "decimal(4, 0)")]
        public decimal NumCuenta { get; set; }
        [Key]
        [Column("sub_cuenta", TypeName = "decimal(4, 0)")]
        public decimal SubCuenta { get; set; }
        [Key]
        [Column("sub_subcuenta", TypeName = "decimal(4, 0)")]
        public decimal SubSubcuenta { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "decimal(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("saldo_inicial", TypeName = "decimal(16, 2)")]
        public decimal SaldoInicial { get; set; }
        [Column("saldo_credito", TypeName = "decimal(16, 2)")]
        public decimal SaldoCredito { get; set; }
        [Column("saldo_debito", TypeName = "decimal(16, 2)")]
        public decimal SaldoDebito { get; set; }
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
    }
}
