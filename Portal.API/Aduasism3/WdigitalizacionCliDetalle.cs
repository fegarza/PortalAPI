using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_cliDetalle")]
    public partial class WdigitalizacionCliDetalle
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("digitalizacion")]
        public int Digitalizacion { get; set; }
        [Column("digitalizacion_web")]
        public bool? DigitalizacionWeb { get; set; }
        [Column("digitalizacion_cliente")]
        public bool? DigitalizacionCliente { get; set; }
        [Column("notificar")]
        public bool Notificar { get; set; }
    }
}
