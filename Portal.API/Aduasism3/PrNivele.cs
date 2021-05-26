using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_niveles")]
    public partial class PrNivele
    {
        [Key]
        [Column("nivel", TypeName = "decimal(2, 0)")]
        public decimal Nivel { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(30)]
        public string Nombre { get; set; }
        [Column("size_control")]
        public int? SizeControl { get; set; }
    }
}
