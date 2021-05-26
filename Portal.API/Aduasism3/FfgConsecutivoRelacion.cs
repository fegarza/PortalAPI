using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_consecutivo_relacion")]
    public partial class FfgConsecutivoRelacion
    {
        [Column("consecutivo_relacion", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoRelacion { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
