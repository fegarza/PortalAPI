using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_origen_cuenta")]
    public partial class CtOrigenCuentum
    {
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Key]
        [Column("numero_detalle", TypeName = "decimal(1, 0)")]
        public decimal NumeroDetalle { get; set; }
        [Key]
        [Column("consec_origen_cuenta", TypeName = "decimal(3, 0)")]
        public decimal ConsecOrigenCuenta { get; set; }
        [Required]
        [Column("debito_credito")]
        [StringLength(1)]
        public string DebitoCredito { get; set; }
        [Required]
        [Column("campo_proyecto")]
        [StringLength(255)]
        public string CampoProyecto { get; set; }
        [Required]
        [Column("campo_cuenta")]
        [StringLength(14)]
        public string CampoCuenta { get; set; }
        [Required]
        [Column("campo_subcuenta")]
        [StringLength(14)]
        public string CampoSubcuenta { get; set; }
        [Required]
        [Column("campo_subsubcuenta")]
        [StringLength(14)]
        public string CampoSubsubcuenta { get; set; }
        [Required]
        [Column("importe")]
        [StringLength(20)]
        public string Importe { get; set; }
        [Required]
        [Column("campo_num_beneficiario")]
        [StringLength(255)]
        public string CampoNumBeneficiario { get; set; }
        [Required]
        [Column("campo_referencia")]
        [StringLength(255)]
        public string CampoReferencia { get; set; }
        [Column("campo_tipo_beneficiario")]
        [StringLength(255)]
        public string CampoTipoBeneficiario { get; set; }
    }
}
