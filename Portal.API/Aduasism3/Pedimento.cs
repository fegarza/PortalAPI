using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class Pedimento
    {
        [Required]
        [Column("ref")]
        [StringLength(10)]
        public string Ref { get; set; }
        [Column("rect", TypeName = "decimal(1, 0)")]
        public decimal Rect { get; set; }
        [Column("ped")]
        [StringLength(7)]
        public string Ped { get; set; }
        [Required]
        [Column("adu")]
        [StringLength(2)]
        public string Adu { get; set; }
        [Required]
        [Column("secc")]
        [StringLength(1)]
        public string Secc { get; set; }
    }
}
