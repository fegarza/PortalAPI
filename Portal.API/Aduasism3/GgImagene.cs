using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_imagenes")]
    public partial class GgImagene
    {
        [Key]
        [Column("icono")]
        [StringLength(3)]
        public string Icono { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Required]
        [Column("modulo")]
        [StringLength(2)]
        public string Modulo { get; set; }
    }
}
