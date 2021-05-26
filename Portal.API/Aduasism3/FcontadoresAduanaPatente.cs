using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcontadores_aduana_patente")]
    public partial class FcontadoresAduanaPatente
    {
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("contador_normal", TypeName = "numeric(3, 0)")]
        public decimal ContadorNormal { get; set; }
        [Column("rango_normal_ini", TypeName = "numeric(3, 0)")]
        public decimal? RangoNormalIni { get; set; }
        [Column("rango_normal_fin", TypeName = "numeric(3, 0)")]
        public decimal? RangoNormalFin { get; set; }
        [Column("contador_bancos", TypeName = "numeric(3, 0)")]
        public decimal ContadorBancos { get; set; }
        [Column("rango_bancos_ini", TypeName = "numeric(3, 0)")]
        public decimal? RangoBancosIni { get; set; }
        [Column("rango_bancos_fin", TypeName = "numeric(3, 0)")]
        public decimal? RangoBancosFin { get; set; }
    }
}
