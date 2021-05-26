using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cp_status")]
    public partial class CpStatus
    {
        [Column("tipostatus", TypeName = "decimal(2, 0)")]
        public decimal Tipostatus { get; set; }
        [Column("cvestatus", TypeName = "decimal(2, 0)")]
        public decimal Cvestatus { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
    }
}
