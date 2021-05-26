using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_leyendas")]
    public partial class FfgLeyenda
    {
        [Key]
        [Column("id_leyenda")]
        [StringLength(2)]
        public string IdLeyenda { get; set; }
        [Column("fecha_alta", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("leyenda_texto", TypeName = "text")]
        public string LeyendaTexto { get; set; }
        [Column("descripcion_reporte")]
        [StringLength(50)]
        public string DescripcionReporte { get; set; }
    }
}
