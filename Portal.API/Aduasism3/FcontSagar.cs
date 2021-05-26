using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcont_sagar")]
    public partial class FcontSagar
    {
        [Key]
        [Column("contador_sagar")]
        public int ContadorSagar { get; set; }
        [Column("rango_ini")]
        public int? RangoIni { get; set; }
        [Column("rango_fin")]
        public int? RangoFin { get; set; }
    }
}
