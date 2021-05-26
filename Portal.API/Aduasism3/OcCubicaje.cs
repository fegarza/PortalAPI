using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_cubicaje")]
    public partial class OcCubicaje
    {
        [Key]
        [Column("id_cubicaje")]
        public short IdCubicaje { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(4)]
        public string Descripcion { get; set; }
    }
}
