using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_detalle")]
    public partial class WdigitalizacionDetalle
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("digitalizacion")]
        public int Digitalizacion { get; set; }
        [Key]
        [Column("parametro")]
        [StringLength(25)]
        public string Parametro { get; set; }
        [Column("valor")]
        [StringLength(50)]
        public string Valor { get; set; }
        [Column("orden")]
        public short Orden { get; set; }
        [Column("separador")]
        [StringLength(1)]
        public string Separador { get; set; }
    }
}
