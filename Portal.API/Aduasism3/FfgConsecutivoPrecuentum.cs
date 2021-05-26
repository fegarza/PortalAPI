using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_consecutivo_precuenta")]
    public partial class FfgConsecutivoPrecuentum
    {
        [Column("consecutivo_precuenta", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoPrecuenta { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
