using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webAplicacion")]
    public partial class WebAplicacion
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("path_reportes")]
        [StringLength(250)]
        public string PathReportes { get; set; }
        [Column("path_logotipo")]
        [StringLength(250)]
        public string PathLogotipo { get; set; }
        [Column("path_documentos")]
        [StringLength(250)]
        public string PathDocumentos { get; set; }
        [Column("mantener_referencia")]
        public bool MantenerReferencia { get; set; }
        [Column("path_url")]
        [StringLength(250)]
        public string PathUrl { get; set; }
    }
}
