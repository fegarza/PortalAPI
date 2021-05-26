using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_det_tipo_poliza_contable")]
    public partial class CtDetTipoPolizaContable
    {
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Key]
        [Column("debito_credito")]
        [StringLength(1)]
        public string DebitoCredito { get; set; }
        [Key]
        [Column("num_cuenta", TypeName = "decimal(4, 0)")]
        public decimal NumCuenta { get; set; }
        [Key]
        [Column("sub_cuenta", TypeName = "decimal(4, 0)")]
        public decimal SubCuenta { get; set; }
        [Key]
        [Column("sub_subcuenta", TypeName = "decimal(4, 0)")]
        public decimal SubSubcuenta { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
    }
}
