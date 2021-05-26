using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("tar_folio")]
    public partial class TarFolio
    {
        [Column("tare_tarekey", TypeName = "numeric(18, 0)")]
        public decimal? TareTarekey { get; set; }
    }
}
