using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_conversion")]
    public partial class CtConversion
    {
        [Key]
        [Column("cve_tabla", TypeName = "decimal(4, 0)")]
        public decimal CveTabla { get; set; }
        [Key]
        [Column("codigo_convertir")]
        [StringLength(14)]
        public string CodigoConvertir { get; set; }
        [Column("codigo_conversion", TypeName = "decimal(6, 0)")]
        public decimal CodigoConversion { get; set; }
    }
}
