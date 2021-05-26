using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webUsuario")]
    public partial class WebUsuario
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Required]
        [Column("correo_electronico")]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [Column("password")]
        [StringLength(250)]
        public string Password { get; set; }
        [Required]
        [Column("tipoUsuario")]
        [StringLength(1)]
        public string TipoUsuario { get; set; }
        [Required]
        [Column("clienteGrupo")]
        [StringLength(6)]
        public string ClienteGrupo { get; set; }
        [Required]
        [Column("locale")]
        [StringLength(2)]
        public string Locale { get; set; }
        [Column("rol")]
        public short Rol { get; set; }
        [Column("theme")]
        [StringLength(30)]
        public string Theme { get; set; }
        [Column("fecha_password", TypeName = "date")]
        public DateTime FechaPassword { get; set; }
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
        [Required]
        [Column("activo")]
        public bool? Activo { get; set; }
        [Column("fecha_bloqueo", TypeName = "datetime")]
        public DateTime? FechaBloqueo { get; set; }
        [Column("tiempoSesion")]
        public int? TiempoSesion { get; set; }
        [Column("puesto")]
        [StringLength(50)]
        public string Puesto { get; set; }
        [Column("fecha_ultima_conexion", TypeName = "datetime")]
        public DateTime? FechaUltimaConexion { get; set; }
        [Column("usuario_aduasis")]
        [StringLength(6)]
        public string UsuarioAduasis { get; set; }
        [Column("id_usuario_usac")]
        public int? IdUsuarioUsac { get; set; }
        [Column("logo")]
        [StringLength(30)]
        public string Logo { get; set; }
        [Column("password_duplicar_factura")]
        [StringLength(15)]
        public string PasswordDuplicarFactura { get; set; }
    }
}
