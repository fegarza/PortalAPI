using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fnumeros_de_orden")]
    public partial class FnumerosDeOrden
    {
        [Key]
        [Column("archivo")]
        [StringLength(50)]
        public string Archivo { get; set; }
        [Key]
        [Column("numero_orden")]
        [StringLength(20)]
        public string NumeroOrden { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
    }
}
