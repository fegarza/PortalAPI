using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcorrel_frac")]
    public partial class FcorrelFrac
    {
        [Key]
        [Column("id_fraccion_ant")]
        [StringLength(8)]
        public string IdFraccionAnt { get; set; }
        [Key]
        [Column("id_fraccion_nva")]
        [StringLength(8)]
        public string IdFraccionNva { get; set; }
        [Key]
        [Column("nico")]
        [StringLength(2)]
        public string Nico { get; set; }
        [Column("actualizacion")]
        [StringLength(10)]
        public string Actualizacion { get; set; }
        [Column("complemento")]
        [StringLength(10)]
        public string Complemento { get; set; }
        [Column("eliminar")]
        [StringLength(10)]
        public string Eliminar { get; set; }
    }
}
