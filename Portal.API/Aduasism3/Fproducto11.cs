using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fproducto1$")]
    public partial class Fproducto11
    {
        [StringLength(20)]
        public string NumParte1 { get; set; }
        [StringLength(20)]
        public string NumParte { get; set; }
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [StringLength(250)]
        public string Descripcion { get; set; }
        [StringLength(250)]
        public string DescripcionIngles { get; set; }
        [Column(TypeName = "decimal(15, 0)")]
        public decimal? Fraccion { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? Peso { get; set; }
        [StringLength(255)]
        public string Unidad { get; set; }
        [StringLength(250)]
        public string DescTarifa { get; set; }
    }
}
