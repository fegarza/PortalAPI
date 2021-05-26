using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_consecutivo_fact_ame")]
    public partial class FfgConsecutivoFactAme
    {
        [Column("consecutivo_fact_ame", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFactAme { get; set; }
    }
}
