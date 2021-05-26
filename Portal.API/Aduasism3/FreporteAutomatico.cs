using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("freporte_automatico")]
    public partial class FreporteAutomatico
    {
        [Key]
        [Column("id_reporte")]
        [StringLength(10)]
        public string IdReporte { get; set; }
        [Column("reporte")]
        [StringLength(30)]
        public string Reporte { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("fecha_fin", TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }
        [Column("contacto")]
        [StringLength(50)]
        public string Contacto { get; set; }
    }
}
