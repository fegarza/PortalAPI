using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_autorizaciones")]
    public partial class GgAutorizacione
    {
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Key]
        [Column("no_tarea")]
        public int NoTarea { get; set; }
        [Key]
        [Column("no_autorizacion")]
        public int NoAutorizacion { get; set; }
        [Key]
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Required]
        [Column("password")]
        [StringLength(25)]
        public string Password { get; set; }
        [Required]
        [Column("password_sec")]
        [StringLength(25)]
        public string PasswordSec { get; set; }
    }
}
