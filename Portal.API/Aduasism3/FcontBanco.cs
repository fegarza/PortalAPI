using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fcont_bancos")]
    public partial class FcontBanco
    {
        [Column("contador_bancos", TypeName = "numeric(3, 0)")]
        public decimal ContadorBancos { get; set; }
        [Column("rango_ini")]
        public int? RangoIni { get; set; }
        [Column("rango_fin")]
        public int? RangoFin { get; set; }
    }
}
