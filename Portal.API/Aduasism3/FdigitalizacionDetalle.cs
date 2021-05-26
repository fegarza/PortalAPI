using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdigitalizacion_detalle")]
    public partial class FdigitalizacionDetalle
    {
        [Key]
        [Column("digitalizacion")]
        public int Digitalizacion { get; set; }
        [Key]
        [Column("parametro")]
        [StringLength(25)]
        public string Parametro { get; set; }
        [Column("valor")]
        [StringLength(50)]
        public string Valor { get; set; }
        [Column("orden")]
        public int Orden { get; set; }
    }
}
