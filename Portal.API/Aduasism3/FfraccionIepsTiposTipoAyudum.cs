using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_ieps_tipos_tipo_ayuda")]
    public partial class FfraccionIepsTiposTipoAyudum
    {
        [Key]
        [Column("tipo")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Key]
        [Column("tipo_ayuda")]
        [StringLength(20)]
        public string TipoAyuda { get; set; }
    }
}
