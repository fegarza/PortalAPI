using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_generales")]
    public partial class WdigitalizacionGenerale
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Required]
        [Column("ruta_digitalizacion")]
        [StringLength(200)]
        public string RutaDigitalizacion { get; set; }
        [Column("url_web")]
        [StringLength(30)]
        public string UrlWeb { get; set; }
        [Column("consecutivoArchivo")]
        public int ConsecutivoArchivo { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
