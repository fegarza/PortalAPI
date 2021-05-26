using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webRol")]
    public partial class WebRol
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("rol")]
        public short Rol { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("idClasificacion")]
        public short IdClasificacion { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("cambiar_almacen")]
        public bool? CambiarAlmacen { get; set; }
        [Column("montacarguista")]
        public bool? Montacarguista { get; set; }
        [Column("revisador")]
        public bool? Revisador { get; set; }
        [Column("cargar_embarque")]
        public bool? CargarEmbarque { get; set; }
        [Column("atiende_alerta_embarque")]
        public bool? AtiendeAlertaEmbarque { get; set; }
        [Column("editar_vehiculo")]
        public bool? EditarVehiculo { get; set; }
    }
}
