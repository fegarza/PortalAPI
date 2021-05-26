using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fimpuesto")]
    [Index(nameof(Rowguid), Name = "index_1405964085", IsUnique = true)]
    public partial class Fimpuesto
    {
        public Fimpuesto()
        {
            FcalculoImpuestos = new HashSet<FcalculoImpuesto>();
            FrelImpRegPagos = new HashSet<FrelImpRegPago>();
        }

        [Key]
        [Column("id_impuesto")]
        [StringLength(2)]
        public string IdImpuesto { get; set; }
        [Required]
        [Column("descripcion_imp")]
        [StringLength(50)]
        public string DescripcionImp { get; set; }
        [Required]
        [Column("desc_abreviado")]
        [StringLength(9)]
        public string DescAbreviado { get; set; }
        [Column("cve_tipo_tasa", TypeName = "numeric(1, 0)")]
        public decimal? CveTipoTasa { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(FcalculoImpuesto.IdImpuestoNavigation))]
        public virtual ICollection<FcalculoImpuesto> FcalculoImpuestos { get; set; }
        [InverseProperty(nameof(FrelImpRegPago.IdImpuestoNavigation))]
        public virtual ICollection<FrelImpRegPago> FrelImpRegPagos { get; set; }
    }
}
