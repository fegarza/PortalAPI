using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_control_estructura")]
    public partial class PrControlEstructura
    {
        [Key]
        [Column("no_proyecto")]
        public int NoProyecto { get; set; }
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("nivel_a")]
        public int NivelA { get; set; }
        [Column("nivel_b")]
        public int NivelB { get; set; }
        [Column("nivel_c")]
        public int NivelC { get; set; }
        [Column("nivel_d")]
        public int NivelD { get; set; }
        [Column("nivel_e")]
        public int NivelE { get; set; }
    }
}
