using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_proceso_directorio")]
    public partial class OcProcesoDirectorio
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("proceso")]
        public short Proceso { get; set; }
        [Column("tipo_directorio")]
        public short TipoDirectorio { get; set; }
        [Column("ruta_in")]
        [StringLength(255)]
        public string RutaIn { get; set; }
        [Column("ruta_out")]
        [StringLength(255)]
        public string RutaOut { get; set; }
        [Column("ftp_host")]
        [StringLength(250)]
        public string FtpHost { get; set; }
        [Column("ftp_puerto")]
        public int? FtpPuerto { get; set; }
        [Column("ftp_usuario")]
        [StringLength(20)]
        public string FtpUsuario { get; set; }
        [Column("ftp_password")]
        [StringLength(50)]
        public string FtpPassword { get; set; }
        [Column("ftp_directorio")]
        [StringLength(250)]
        public string FtpDirectorio { get; set; }
        [Required]
        [Column("activo")]
        public bool? Activo { get; set; }
        [Column("tipo_directorio_out")]
        public short TipoDirectorioOut { get; set; }
        [Column("ftp_host_out")]
        [StringLength(250)]
        public string FtpHostOut { get; set; }
        [Column("ftp_puerto_out")]
        public int? FtpPuertoOut { get; set; }
        [Column("ftp_usuario_out")]
        [StringLength(20)]
        public string FtpUsuarioOut { get; set; }
        [Column("ftp_password_out")]
        [StringLength(50)]
        public string FtpPasswordOut { get; set; }
        [Column("ftp_directorio_out")]
        [StringLength(250)]
        public string FtpDirectorioOut { get; set; }
        [Column("generar_docs_defaults")]
        public bool? GenerarDocsDefaults { get; set; }
        [Column("sftp_host")]
        [StringLength(90)]
        public string SftpHost { get; set; }
        [Column("sftp_puerto")]
        public short? SftpPuerto { get; set; }
        [Column("sftp_usuario")]
        [StringLength(30)]
        public string SftpUsuario { get; set; }
        [Column("sftp_password")]
        [StringLength(90)]
        public string SftpPassword { get; set; }
        [Column("sftp_tipo_autenticacion")]
        public byte? SftpTipoAutenticacion { get; set; }
        [Column("sftp_privatekey_route")]
        [StringLength(250)]
        public string SftpPrivatekeyRoute { get; set; }
        [Column("sftp_privatekey_phrase")]
        [StringLength(90)]
        public string SftpPrivatekeyPhrase { get; set; }
        [Column("sftp_directorio_in")]
        [StringLength(250)]
        public string SftpDirectorioIn { get; set; }
        [Column("sftp_directorio_out")]
        [StringLength(250)]
        public string SftpDirectorioOut { get; set; }
        [Column("sftp_ultima_ejecucion", TypeName = "datetime")]
        public DateTime? SftpUltimaEjecucion { get; set; }
        [Column("sftp_timeout")]
        public int? SftpTimeout { get; set; }
    }
}
