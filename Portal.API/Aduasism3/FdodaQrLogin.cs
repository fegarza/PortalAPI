using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr_login")]
    public partial class FdodaQrLogin
    {
        [Key]
        [Column("usuario")]
        [StringLength(120)]
        public string Usuario { get; set; }
        [Required]
        [Column("clave")]
        [StringLength(400)]
        public string Clave { get; set; }
    }
}
