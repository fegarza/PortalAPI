using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_xml_ws")]
    public partial class FcoveXmlW
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Key]
        [Column("cove")]
        [StringLength(13)]
        public string Cove { get; set; }
        [Column("ruta_xml")]
        [StringLength(500)]
        public string RutaXml { get; set; }
        [Column("descripcion_error")]
        [StringLength(500)]
        public string DescripcionError { get; set; }
        [Column("fecha_generacion", TypeName = "datetime")]
        public DateTime? FechaGeneracion { get; set; }
    }
}
