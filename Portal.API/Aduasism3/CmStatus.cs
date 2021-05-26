using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_status")]
    public partial class CmStatus
    {
        [Key]
        [Column("tipostatus", TypeName = "decimal(2, 0)")]
        public decimal Tipostatus { get; set; }
        [Key]
        [Column("cvestatus", TypeName = "decimal(2, 0)")]
        public decimal Cvestatus { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
    }
}
