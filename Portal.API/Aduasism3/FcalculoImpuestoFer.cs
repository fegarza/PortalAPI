using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcalculo_impuesto_fer")]
    [Index(nameof(Rowguid), Name = "index_1325963800", IsUnique = true)]
    public partial class FcalculoImpuestoFer
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
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
    }
}
