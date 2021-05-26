using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcoved_pdf")]
    public partial class FcovedPdf
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Key]
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("ruta_pdf")]
        [StringLength(500)]
        public string RutaPdf { get; set; }
        [Column("descripcion_error")]
        [StringLength(500)]
        public string DescripcionError { get; set; }
        [Column("fecha_generacion", TypeName = "datetime")]
        public DateTime? FechaGeneracion { get; set; }
    }
}
