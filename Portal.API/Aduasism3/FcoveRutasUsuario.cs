using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_rutas_usuario")]
    public partial class FcoveRutasUsuario
    {
        [Key]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
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
    }
}
