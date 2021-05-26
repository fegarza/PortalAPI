using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_consecu_nota")]
    public partial class FfgConsecuNotum
    {
        [Column("consec_nota_cargo", TypeName = "numeric(7, 0)")]
        public decimal ConsecNotaCargo { get; set; }
    }
}
