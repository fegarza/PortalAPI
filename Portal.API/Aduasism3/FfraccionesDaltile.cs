using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffracciones_daltile")]
    public partial class FfraccionesDaltile
    {
        [Key]
        [Column("fraccion_daltile")]
        [StringLength(6)]
        public string FraccionDaltile { get; set; }
        [Required]
        [Column("fraccion_mex")]
        [StringLength(8)]
        public string FraccionMex { get; set; }
        [Required]
        [Column("descripcion_clas")]
        [StringLength(150)]
        public string DescripcionClas { get; set; }
    }
}
