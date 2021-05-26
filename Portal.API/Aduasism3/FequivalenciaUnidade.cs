using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fequivalencia_unidades")]
    [Index(nameof(Rowguid), Name = "index_1362103893", IsUnique = true)]
    public partial class FequivalenciaUnidade
    {
        [Key]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("factor", TypeName = "decimal(12, 8)")]
        public decimal? Factor { get; set; }
        [Key]
        [Column("id_unidad_mexicana")]
        [StringLength(5)]
        public string IdUnidadMexicana { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdUnidadMexicana))]
        [InverseProperty(nameof(FunidadUniversal.FequivalenciaUnidadeIdUnidadMexicanaNavigations))]
        public virtual FunidadUniversal IdUnidadMexicanaNavigation { get; set; }
        [ForeignKey(nameof(IdUnidadUniversal))]
        [InverseProperty(nameof(FunidadUniversal.FequivalenciaUnidadeIdUnidadUniversalNavigations))]
        public virtual FunidadUniversal IdUnidadUniversalNavigation { get; set; }
    }
}
