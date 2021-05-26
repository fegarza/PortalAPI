using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_suscripcion")]
    public partial class DigSuscripcion
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_evento")]
        [StringLength(20)]
        public string IdEvento { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(100)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("activo")]
        public bool Activo { get; set; }
        [Column("notificado")]
        public bool Notificado { get; set; }
        [Column("fecha_notificacion", TypeName = "datetime")]
        public DateTime? FechaNotificacion { get; set; }
        [Required]
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
    }
}
