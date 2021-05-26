using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ftipo_material_prod")]
    public partial class FtipoMaterialProd
    {
        [Required]
        [Column("id_tipo_material")]
        [StringLength(2)]
        public string IdTipoMaterial { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
