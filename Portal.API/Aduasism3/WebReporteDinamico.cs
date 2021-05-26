using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webReporteDinamico")]
    public partial class WebReporteDinamico
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_reporte")]
        [StringLength(50)]
        public string IdReporte { get; set; }
        [Column("grupo")]
        public bool? Grupo { get; set; }
        [Column("grupo_columna")]
        [StringLength(50)]
        public string GrupoColumna { get; set; }
    }
}
