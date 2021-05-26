using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fdigitalizacion_generales")]
    public partial class FdigitalizacionGenerale
    {
        [Required]
        [Column("ruta_digitalizacion")]
        [StringLength(200)]
        public string RutaDigitalizacion { get; set; }
        [Required]
        [Column("ruta_web")]
        [StringLength(200)]
        public string RutaWeb { get; set; }
        [Column("url_web")]
        [StringLength(30)]
        public string UrlWeb { get; set; }
    }
}
