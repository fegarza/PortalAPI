using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webAplicacion_correo")]
    public partial class WebAplicacionCorreo
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Required]
        [Column("smtpProtocol")]
        [StringLength(10)]
        public string SmtpProtocol { get; set; }
        [Required]
        [Column("smtpHost")]
        [StringLength(50)]
        public string SmtpHost { get; set; }
        [Column("smtpPort")]
        public int SmtpPort { get; set; }
        [Column("smtpTls")]
        public bool SmtpTls { get; set; }
        [Required]
        [Column("emailUserName")]
        [StringLength(50)]
        public string EmailUserName { get; set; }
        [Required]
        [Column("emailUserPassword")]
        [StringLength(250)]
        public string EmailUserPassword { get; set; }
        [Column("fromEmailAddress")]
        [StringLength(50)]
        public string FromEmailAddress { get; set; }
        [Required]
        [Column("fromEmailName")]
        [StringLength(50)]
        public string FromEmailName { get; set; }
        [Required]
        [Column("smtpAuth")]
        public bool? SmtpAuth { get; set; }
    }
}
