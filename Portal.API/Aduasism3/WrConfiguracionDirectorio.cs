using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_configuracion_directorio")]
    public partial class WrConfiguracionDirectorio
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_configuracion")]
        public int IdConfiguracion { get; set; }
        [Column("id_tipo_directorio")]
        public short IdTipoDirectorio { get; set; }
        [Column("ruta")]
        [StringLength(255)]
        public string Ruta { get; set; }
        [Column("ftp_host")]
        [StringLength(250)]
        public string FtpHost { get; set; }
        [Column("ftp_puerto")]
        public int? FtpPuerto { get; set; }
        [Column("ftp_usuario")]
        [StringLength(20)]
        public string FtpUsuario { get; set; }
        [Column("ftp_password")]
        [StringLength(250)]
        public string FtpPassword { get; set; }
        [Column("ftp_directorio")]
        [StringLength(250)]
        public string FtpDirectorio { get; set; }
    }
}
