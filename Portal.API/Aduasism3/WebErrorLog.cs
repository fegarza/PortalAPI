using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webError_log")]
    public partial class WebErrorLog
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
        [Required]
        [Column("ip_addres")]
        [StringLength(50)]
        public string IpAddres { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
    }
}
