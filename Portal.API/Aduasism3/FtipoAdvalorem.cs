using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_advalorem")]
    [Index(nameof(Rowguid), Name = "index_482100758", IsUnique = true)]
    public partial class FtipoAdvalorem
    {
        public FtipoAdvalorem()
        {
            FcalculoFraccions = new HashSet<FcalculoFraccion>();
            Fdtraficos = new HashSet<Fdtrafico>();
            FrelFracAdvas = new HashSet<FrelFracAdva>();
        }

        [Key]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Required]
        [Column("desc_tipo_adv")]
        [StringLength(50)]
        public string DescTipoAdv { get; set; }
        [Required]
        [Column("desc_tipo_adv_abre")]
        [StringLength(10)]
        public string DescTipoAdvAbre { get; set; }
        [Column("id_pais")]
        [StringLength(4)]
        public string IdPais { get; set; }
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Column("ident_caso")]
        [StringLength(20)]
        public string IdentCaso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(FcalculoFraccion.IdTipoAdvaloremNavigation))]
        public virtual ICollection<FcalculoFraccion> FcalculoFraccions { get; set; }
        [InverseProperty(nameof(Fdtrafico.IdTipoAdvaloremNavigation))]
        public virtual ICollection<Fdtrafico> Fdtraficos { get; set; }
        [InverseProperty(nameof(FrelFracAdva.IdTipoAdvaloremNavigation))]
        public virtual ICollection<FrelFracAdva> FrelFracAdvas { get; set; }
    }
}
