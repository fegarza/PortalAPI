using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_password_web")]
    public partial class TpPasswordWeb
    {
        [Key]
        [Column("patente")]
        public int Patente { get; set; }
        [Required]
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Required]
        [Column("password_web")]
        public string PasswordWeb { get; set; }
    }
}
