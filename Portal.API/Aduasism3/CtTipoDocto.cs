using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_tipo_docto")]
    public partial class CtTipoDocto
    {
        [Key]
        [Column("tipo_documento", TypeName = "numeric(3, 0)")]
        public decimal TipoDocumento { get; set; }
        [Required]
        [Column("nombre_corto")]
        [StringLength(5)]
        public string NombreCorto { get; set; }
        [Required]
        [Column("descr_tipo_docto")]
        [StringLength(60)]
        public string DescrTipoDocto { get; set; }
    }
}
