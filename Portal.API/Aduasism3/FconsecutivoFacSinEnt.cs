using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_fac_sin_ent")]
    public partial class FconsecutivoFacSinEnt
    {
        [Column("consecutivo_fac_sin_ent", TypeName = "numeric(9, 0)")]
        public decimal? ConsecutivoFacSinEnt { get; set; }
    }
}
