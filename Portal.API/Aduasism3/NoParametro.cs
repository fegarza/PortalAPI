using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("no_parametros")]
    public partial class NoParametro
    {
        [Column("tipo_parametro", TypeName = "decimal(2, 0)")]
        public decimal TipoParametro { get; set; }
        [Required]
        [Column("cve_parametro")]
        [StringLength(20)]
        public string CveParametro { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("fecha_actualizacion", TypeName = "datetime")]
        public DateTime FechaActualizacion { get; set; }
    }
}
