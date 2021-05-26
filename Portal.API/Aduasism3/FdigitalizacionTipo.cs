using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdigitalizacion_tipo")]
    public partial class FdigitalizacionTipo
    {
        [Key]
        [Column("tipo_documento")]
        public int TipoDocumento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("separador")]
        [StringLength(1)]
        public string Separador { get; set; }
    }
}
