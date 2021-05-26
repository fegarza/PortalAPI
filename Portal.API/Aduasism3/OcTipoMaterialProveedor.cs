using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tipo_material_proveedor")]
    public partial class OcTipoMaterialProveedor
    {
        [Key]
        [Column("id_tipo_material_proveedor")]
        [StringLength(4)]
        public string IdTipoMaterialProveedor { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
    }
}
