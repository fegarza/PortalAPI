using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_proyecto")]
    public partial class OcProyecto
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("proyecto")]
        [StringLength(15)]
        public string Proyecto { get; set; }
        [Column("fecha_inicio", TypeName = "date")]
        public DateTime FechaInicio { get; set; }
        [Column("fecha_cierre", TypeName = "date")]
        public DateTime FechaCierre { get; set; }
        [Required]
        [Column("proyecto_activo")]
        public bool? ProyectoActivo { get; set; }
    }
}
