using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_incoterm")]
    public partial class OcIncoterm
    {
        [Key]
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Column("incluir_flete")]
        public bool IncluirFlete { get; set; }
    }
}
