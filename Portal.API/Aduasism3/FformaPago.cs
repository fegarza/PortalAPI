using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fforma_pago")]
    [Index(nameof(Rowguid), Name = "index_1525580473", IsUnique = true)]
    public partial class FformaPago
    {
        public FformaPago()
        {
            FcalculoImpuestos = new HashSet<FcalculoImpuesto>();
            FrelImpRegPagoCvePagoDefaultNavigations = new HashSet<FrelImpRegPago>();
            FrelImpRegPagoIdFormaPagoNavigations = new HashSet<FrelImpRegPago>();
        }

        [Key]
        [Column("id_forma_pago")]
        [StringLength(2)]
        public string IdFormaPago { get; set; }
        [Required]
        [Column("descripcion_pago")]
        [StringLength(50)]
        public string DescripcionPago { get; set; }
        [Required]
        [Column("descripcion_abreviada")]
        [StringLength(10)]
        public string DescripcionAbreviada { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(FcalculoImpuesto.IdFormaPagoNavigation))]
        public virtual ICollection<FcalculoImpuesto> FcalculoImpuestos { get; set; }
        [InverseProperty(nameof(FrelImpRegPago.CvePagoDefaultNavigation))]
        public virtual ICollection<FrelImpRegPago> FrelImpRegPagoCvePagoDefaultNavigations { get; set; }
        [InverseProperty(nameof(FrelImpRegPago.IdFormaPagoNavigation))]
        public virtual ICollection<FrelImpRegPago> FrelImpRegPagoIdFormaPagoNavigations { get; set; }
    }
}
