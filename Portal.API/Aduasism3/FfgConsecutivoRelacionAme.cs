using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_consecutivo_relacion_ame")]
    public partial class FfgConsecutivoRelacionAme
    {
        [Column("consecutivo_relacion_ame", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoRelacionAme { get; set; }
    }
}
