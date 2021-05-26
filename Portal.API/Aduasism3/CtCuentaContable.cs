using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_cuenta_contable")]
    public partial class CtCuentaContable
    {
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
        [Column("numempresa", TypeName = "numeric(3, 0)")]
        public decimal Numempresa { get; set; }
        [Required]
        [Column("descri_cuenta")]
        [StringLength(60)]
        public string DescriCuenta { get; set; }
        [Required]
        [Column("cta_balance_resultado")]
        [StringLength(1)]
        public string CtaBalanceResultado { get; set; }
        [Required]
        [Column("naturaleza_cuenta")]
        [StringLength(1)]
        public string NaturalezaCuenta { get; set; }
        [Required]
        [Column("monetaria")]
        [StringLength(1)]
        public string Monetaria { get; set; }
        [Required]
        [Column("formula_saldo_prom")]
        [StringLength(1)]
        public string FormulaSaldoProm { get; set; }
        [Required]
        [Column("status_cuenta")]
        [StringLength(1)]
        public string StatusCuenta { get; set; }
        [Column("tipo_cuenta")]
        [StringLength(3)]
        public string TipoCuenta { get; set; }
    }
}
