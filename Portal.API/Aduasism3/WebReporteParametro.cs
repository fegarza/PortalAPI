using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("web_reporte_parametro")]
    public partial class WebReporteParametro
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_reporte")]
        public short IdReporte { get; set; }
        [Key]
        [Column("id_parametro")]
        [StringLength(50)]
        public string IdParametro { get; set; }
    }
}
