using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("gg_mascaras_campos")]
    public partial class GgMascarasCampo
    {
        [Required]
        [Column("nombre_campo")]
        [StringLength(50)]
        public string NombreCampo { get; set; }
        [Required]
        [Column("tipo_mascara")]
        [StringLength(50)]
        public string TipoMascara { get; set; }
    }
}
