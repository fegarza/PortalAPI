using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_permiso")]
    [Index(nameof(Rowguid), Name = "index_802101898", IsUnique = true)]
    public partial class FtipoPermiso
    {
        public FtipoPermiso()
        {
            Fpermisos = new HashSet<Fpermiso>();
        }

        [Key]
        [Column("id_tipo_permiso")]
        [StringLength(3)]
        public string IdTipoPermiso { get; set; }
        [Required]
        [Column("desc_tipo_perm")]
        [StringLength(50)]
        public string DescTipoPerm { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(Fpermiso.IdTipoPermisoNavigation))]
        public virtual ICollection<Fpermiso> Fpermisos { get; set; }
    }
}
