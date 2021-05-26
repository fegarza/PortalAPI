using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_dta_rectificacion")]
    public partial class TpDtaRectificacion
    {
        [Key]
        [Column("anio")]
        [StringLength(4)]
        public string Anio { get; set; }
        [Column("importe", TypeName = "numeric(12, 0)")]
        public decimal Importe { get; set; }
    }
}
