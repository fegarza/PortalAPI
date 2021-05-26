using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tipo_flete")]
    public partial class OcTipoFlete
    {
        [Key]
        [Column("tipo_flete")]
        public short TipoFlete { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(30)]
        public string DescripcionEn { get; set; }
    }
}
