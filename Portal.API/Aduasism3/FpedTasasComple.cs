using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_tasas_comple")]
    [Index(nameof(Rowguid), Name = "index_347200337", IsUnique = true)]
    public partial class FpedTasasComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_impuesto")]
        [StringLength(3)]
        public string IdImpuesto { get; set; }
        [Key]
        [Column("forma_pago")]
        [StringLength(2)]
        public string FormaPago { get; set; }
        [Column("importe", TypeName = "decimal(12, 0)")]
        public decimal? Importe { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
