using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsituacion")]
    public partial class Fsituacion
    {
        [Key]
        [Column("pk1", TypeName = "numeric(4, 0)")]
        public decimal Pk1 { get; set; }
        [Column("situacion")]
        [StringLength(50)]
        public string Situacion { get; set; }
    }
}
