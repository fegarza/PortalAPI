using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_consecutivo_rendicion")]
    public partial class FfgConsecutivoRendicion
    {
        [Column("consecutivo_rendicion", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoRendicion { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
