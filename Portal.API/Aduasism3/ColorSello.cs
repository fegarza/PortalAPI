using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("color_sellos")]
    public partial class ColorSello
    {
        [Key]
        [Column("color")]
        [StringLength(1)]
        public string Color { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(30)]
        public string DescripcionEn { get; set; }
    }
}
