using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_presupuesto_contable")]
    public partial class CtPresupuestoContable
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("tipo_proforma", TypeName = "decimal(3, 0)")]
        public decimal TipoProforma { get; set; }
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
        [Column("valor_presupuestado", TypeName = "decimal(16, 2)")]
        public decimal? ValorPresupuestado { get; set; }
    }
}
