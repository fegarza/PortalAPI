using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fracciones_nuevas")]
    public partial class FraccionesNueva
    {
        [Key]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Key]
        [Column("id_fraccion_nueva")]
        [StringLength(8)]
        public string IdFraccionNueva { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("umt")]
        [StringLength(2)]
        public string Umt { get; set; }
    }
}
