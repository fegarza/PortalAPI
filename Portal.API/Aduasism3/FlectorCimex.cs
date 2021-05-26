using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("flector_cimex")]
    public partial class FlectorCimex
    {
        [Column("autonumber", TypeName = "decimal(18, 0)")]
        public decimal Autonumber { get; set; }
        [Required]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("id_producto")]
        [StringLength(16)]
        public string IdProducto { get; set; }
        [Required]
        [Column("serie")]
        [StringLength(20)]
        public string Serie { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
    }
}
