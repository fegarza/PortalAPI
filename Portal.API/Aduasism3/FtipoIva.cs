using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_iva")]
    [Index(nameof(Rowguid), Name = "index_706101556", IsUnique = true)]
    public partial class FtipoIva
    {
        public FtipoIva()
        {
            Fregimen = new HashSet<Fregiman>();
        }

        [Key]
        [Column("id_tipo_iva")]
        [StringLength(2)]
        public string IdTipoIva { get; set; }
        [Column("porc_iva", TypeName = "numeric(5, 2)")]
        public decimal PorcIva { get; set; }
        [Required]
        [Column("descripcion_tipo_iva")]
        [StringLength(50)]
        public string DescripcionTipoIva { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("iva_cob_num_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaCobNumCta { get; set; }
        [Column("iva_cob_sub_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaCobSubCta { get; set; }
        [Column("iva_cob_sub_subcta", TypeName = "decimal(4, 0)")]
        public decimal? IvaCobSubSubcta { get; set; }
        [Column("iva_fac_num_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaFacNumCta { get; set; }
        [Column("iva_fac_sub_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaFacSubCta { get; set; }
        [Column("iva_fac_sub_subcta", TypeName = "decimal(4, 0)")]
        public decimal? IvaFacSubSubcta { get; set; }
        [Column("hon_cob_num_cta", TypeName = "decimal(4, 0)")]
        public decimal? HonCobNumCta { get; set; }
        [Column("hon_cob_sub_cta", TypeName = "decimal(4, 0)")]
        public decimal? HonCobSubCta { get; set; }
        [Column("hon_cob_sub_subcta", TypeName = "decimal(4, 0)")]
        public decimal? HonCobSubSubcta { get; set; }
        [Column("hon_fac_num_cta", TypeName = "decimal(4, 0)")]
        public decimal? HonFacNumCta { get; set; }
        [Column("hon_fac_sub_cta", TypeName = "decimal(4, 0)")]
        public decimal? HonFacSubCta { get; set; }
        [Column("hon_fac_sub_subcta", TypeName = "decimal(4, 0)")]
        public decimal? HonFacSubSubcta { get; set; }

        [InverseProperty(nameof(Fregiman.IdTipoIvaNavigation))]
        public virtual ICollection<Fregiman> Fregimen { get; set; }
    }
}
