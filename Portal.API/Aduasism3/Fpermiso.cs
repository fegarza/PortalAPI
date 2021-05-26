using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpermiso")]
    public partial class Fpermiso
    {
        [Key]
        [Column("id_permiso")]
        [StringLength(3)]
        public string IdPermiso { get; set; }
        [Required]
        [Column("descripcion_perm")]
        [StringLength(50)]
        public string DescripcionPerm { get; set; }
        [Required]
        [Column("descripcion_larga", TypeName = "text")]
        public string DescripcionLarga { get; set; }
        [Required]
        [Column("id_tipo_permiso")]
        [StringLength(3)]
        public string IdTipoPermiso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdTipoPermiso))]
        [InverseProperty(nameof(FtipoPermiso.Fpermisos))]
        public virtual FtipoPermiso IdTipoPermisoNavigation { get; set; }
    }
}
