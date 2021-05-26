using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcont_normal_aux")]
    public partial class FcontNormalAux
    {
        [Key]
        [Column("contador_normal")]
        public int ContadorNormal { get; set; }
        [Column("rango_ini")]
        public int? RangoIni { get; set; }
        [Column("rango_fin")]
        public int? RangoFin { get; set; }
    }
}
