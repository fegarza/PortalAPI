using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("feventos_aduana_subedo")]
    public partial class FeventosAduanaSubedo
    {
        [Key]
        [Column("id_edo")]
        [StringLength(2)]
        public string IdEdo { get; set; }
        [Key]
        [Column("id_subedo")]
        [StringLength(3)]
        public string IdSubedo { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("notificacion")]
        [StringLength(1)]
        public string Notificacion { get; set; }
        [Column("notificacion_interna")]
        [StringLength(1)]
        public string NotificacionInterna { get; set; }
        [Column("eventos_aduana")]
        [StringLength(1)]
        public string EventosAduana { get; set; }
    }
}
