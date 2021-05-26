using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_tipoinsumo")]
    public partial class CmTipoinsumo
    {
        [Key]
        [Column("tipo_insumo")]
        public int TipoInsumo { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("nombre_tabla")]
        [StringLength(20)]
        public string NombreTabla { get; set; }
    }
}
