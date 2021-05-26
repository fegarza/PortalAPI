using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fnomenclatura")]
    public partial class Fnomenclatura
    {
        [Key]
        [Column("tipo_reporte")]
        [StringLength(20)]
        public string TipoReporte { get; set; }
        [Column("nomenclatura")]
        [StringLength(30)]
        public string Nomenclatura { get; set; }
    }
}
