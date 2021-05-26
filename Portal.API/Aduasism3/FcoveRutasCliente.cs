using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_rutas_cliente")]
    public partial class FcoveRutasCliente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("ruta_xml")]
        [StringLength(250)]
        public string RutaXml { get; set; }
        [Column("usuario")]
        [StringLength(50)]
        public string Usuario { get; set; }
        [Column("contrasena_web")]
        [StringLength(100)]
        public string ContrasenaWeb { get; set; }
        [Column("ruta_key")]
        [StringLength(250)]
        public string RutaKey { get; set; }
        [Column("contrasena")]
        [StringLength(50)]
        public string Contrasena { get; set; }
        [Column("ruta_cer")]
        [StringLength(250)]
        public string RutaCer { get; set; }
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("cer_vencimiento")]
        [StringLength(1)]
        public string CerVencimiento { get; set; }
        [Column("cer_vencimiento_fecha", TypeName = "datetime")]
        public DateTime? CerVencimientoFecha { get; set; }
        [Column("sha256")]
        [StringLength(1)]
        public string Sha256 { get; set; }
        [Column("corresponsal")]
        [StringLength(1)]
        public string Corresponsal { get; set; }
    }
}
