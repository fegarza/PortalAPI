using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcalculo_impuesto")]
    [Index(nameof(Rowguid), Name = "index_1261963572", IsUnique = true)]
    public partial class FcalculoImpuesto
    {
        [Key]
        [Column("id_calculo")]
        [StringLength(6)]
        public string IdCalculo { get; set; }
        [Key]
        [Column("id_impuesto")]
        [StringLength(2)]
        public string IdImpuesto { get; set; }
        [Column("importe_efectivo", TypeName = "decimal(12, 0)")]
        public decimal? ImporteEfectivo { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 0)")]
        public decimal? ImporteOtros { get; set; }
        [Column("id_forma_pago")]
        [StringLength(2)]
        public string IdFormaPago { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_forma_pago2")]
        [StringLength(250)]
        public string IdFormaPago2 { get; set; }

        [ForeignKey(nameof(IdCalculo))]
        [InverseProperty(nameof(FcalculoGeneral.FcalculoImpuestos))]
        public virtual FcalculoGeneral IdCalculoNavigation { get; set; }
        [ForeignKey(nameof(IdFormaPago))]
        [InverseProperty(nameof(FformaPago.FcalculoImpuestos))]
        public virtual FformaPago IdFormaPagoNavigation { get; set; }
        [ForeignKey(nameof(IdImpuesto))]
        [InverseProperty(nameof(Fimpuesto.FcalculoImpuestos))]
        public virtual Fimpuesto IdImpuestoNavigation { get; set; }
    }
}
