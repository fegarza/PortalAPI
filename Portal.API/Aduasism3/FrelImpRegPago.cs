using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_imp_reg_pago")]
    [Index(nameof(Rowguid), Name = "index_1309963743", IsUnique = true)]
    public partial class FrelImpRegPago
    {
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("id_impuesto")]
        [StringLength(2)]
        public string IdImpuesto { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Key]
        [Column("id_forma_pago")]
        [StringLength(2)]
        public string IdFormaPago { get; set; }
        [Required]
        [Column("cve_pago_default")]
        [StringLength(2)]
        public string CvePagoDefault { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(CvePagoDefault))]
        [InverseProperty(nameof(FformaPago.FrelImpRegPagoCvePagoDefaultNavigations))]
        public virtual FformaPago CvePagoDefaultNavigation { get; set; }
        [ForeignKey("CveTipoOperacion,IdRegimen")]
        [InverseProperty("FrelImpRegPagos")]
        public virtual Fregiman Fregiman { get; set; }
        [ForeignKey(nameof(IdFormaPago))]
        [InverseProperty(nameof(FformaPago.FrelImpRegPagoIdFormaPagoNavigations))]
        public virtual FformaPago IdFormaPagoNavigation { get; set; }
        [ForeignKey(nameof(IdImpuesto))]
        [InverseProperty(nameof(Fimpuesto.FrelImpRegPagos))]
        public virtual Fimpuesto IdImpuestoNavigation { get; set; }
    }
}
