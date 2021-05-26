using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_areas_costos")]
    public partial class CoAreasCosto
    {
        [Key]
        [Column("cve_area", TypeName = "decimal(3, 0)")]
        public decimal CveArea { get; set; }
        [Column("nombre")]
        [StringLength(60)]
        public string Nombre { get; set; }
    }
}
