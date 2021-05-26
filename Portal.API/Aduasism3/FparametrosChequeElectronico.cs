using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fparametros_cheque_electronico")]
    public partial class FparametrosChequeElectronico
    {
        [Required]
        [Column("num_banco_ped")]
        [StringLength(2)]
        public string NumBancoPed { get; set; }
        [Column("num_banco_fun", TypeName = "decimal(2, 0)")]
        public decimal NumBancoFun { get; set; }
        [Required]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("num_beneficario", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficario { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("poliza_electronica")]
        [StringLength(1)]
        public string PolizaElectronica { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
    }
}
