using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webUsuario_password")]
    public partial class WebUsuarioPassword
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Required]
        [Column("codigo")]
        [StringLength(250)]
        public string Codigo { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
    }
}
