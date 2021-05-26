using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_ieps_tipos_tipo_moneda_ayuda")]
    public partial class FfraccionIepsTiposTipoMonedaAyudum
    {
        [Key]
        [Column("tipo_moneda")]
        [StringLength(3)]
        public string TipoMoneda { get; set; }
        [Key]
        [Column("tipo_moneda_ayuda")]
        [StringLength(40)]
        public string TipoMonedaAyuda { get; set; }
    }
}
