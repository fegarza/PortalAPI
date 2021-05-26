using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faduasis_ws_security")]
    public partial class FaduasisWsSecurity
    {
        [Key]
        [Column("usuario")]
        [StringLength(10)]
        public string Usuario { get; set; }
        [Column("contrasena")]
        [StringLength(50)]
        public string Contrasena { get; set; }
    }
}
