using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_configuracion_email")]
    public partial class WrConfiguracionEmail
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_configuracion")]
        public int IdConfiguracion { get; set; }
        [Key]
        [Column("id_email")]
        public int IdEmail { get; set; }
        [Required]
        [Column("activo")]
        public bool? Activo { get; set; }
    }
}
