using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("funidad_universal")]
    [Index(nameof(Rowguid), Name = "index_1058102810", IsUnique = true)]
    public partial class FunidadUniversal
    {
        public FunidadUniversal()
        {
            Fdfactura2s = new HashSet<Fdfactura2>();
            FdfacturaElects = new HashSet<FdfacturaElect>();
            Fdfacturas = new HashSet<Fdfactura>();
            FequivalenciaUnidadeIdUnidadMexicanaNavigations = new HashSet<FequivalenciaUnidade>();
            FequivalenciaUnidadeIdUnidadUniversalNavigations = new HashSet<FequivalenciaUnidade>();
            FfraccionMexns = new HashSet<FfraccionMexn>();
            FfraccionMices = new HashSet<FfraccionMex>();
        }

        [Key]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Column("desc_abreviada")]
        [StringLength(5)]
        public string DescAbreviada { get; set; }
        [Column("cve_mexicana")]
        [StringLength(1)]
        public string CveMexicana { get; set; }
        [Column("cve_unidad_oficial")]
        [StringLength(2)]
        public string CveUnidadOficial { get; set; }
        [Column("abrevia_ame")]
        [StringLength(12)]
        public string AbreviaAme { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("unidad_cove")]
        [StringLength(30)]
        public string UnidadCove { get; set; }
        [Column("descripcion_cove")]
        [StringLength(50)]
        public string DescripcionCove { get; set; }
        [Column("unidad_um")]
        [StringLength(5)]
        public string UnidadUm { get; set; }
        [Column("descripcion_en")]
        [StringLength(40)]
        public string DescripcionEn { get; set; }
        [Column("entero")]
        [StringLength(1)]
        public string Entero { get; set; }

        [InverseProperty(nameof(Fdfactura2.IdUnidadUniversalNavigation))]
        public virtual ICollection<Fdfactura2> Fdfactura2s { get; set; }
        [InverseProperty(nameof(FdfacturaElect.IdUnidadUniversalNavigation))]
        public virtual ICollection<FdfacturaElect> FdfacturaElects { get; set; }
        [InverseProperty(nameof(Fdfactura.IdUnidadUniversalNavigation))]
        public virtual ICollection<Fdfactura> Fdfacturas { get; set; }
        [InverseProperty(nameof(FequivalenciaUnidade.IdUnidadMexicanaNavigation))]
        public virtual ICollection<FequivalenciaUnidade> FequivalenciaUnidadeIdUnidadMexicanaNavigations { get; set; }
        [InverseProperty(nameof(FequivalenciaUnidade.IdUnidadUniversalNavigation))]
        public virtual ICollection<FequivalenciaUnidade> FequivalenciaUnidadeIdUnidadUniversalNavigations { get; set; }
        [InverseProperty(nameof(FfraccionMexn.IdUnidadUniversalNavigation))]
        public virtual ICollection<FfraccionMexn> FfraccionMexns { get; set; }
        [InverseProperty(nameof(FfraccionMex.IdUnidadUniversalNavigation))]
        public virtual ICollection<FfraccionMex> FfraccionMices { get; set; }
    }
}
