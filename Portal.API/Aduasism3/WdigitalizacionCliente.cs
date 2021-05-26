using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_cliente")]
    public partial class WdigitalizacionCliente
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("ruta_digitalizacion")]
        [StringLength(200)]
        public string RutaDigitalizacion { get; set; }
        [Column("ruta_web")]
        [StringLength(250)]
        public string RutaWeb { get; set; }
        [Column("digitalizacion_edocument")]
        public bool DigitalizacionEdocument { get; set; }
        [Column("ruta_edocument")]
        [StringLength(250)]
        public string RutaEdocument { get; set; }
    }
}
