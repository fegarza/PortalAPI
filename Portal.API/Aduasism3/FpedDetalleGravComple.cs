using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_detalle_grav_comple")]
    [Index(nameof(Rowguid), Name = "index_731201705", IsUnique = true)]
    public partial class FpedDetalleGravComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Key]
        [Column("id_impuesto")]
        [StringLength(2)]
        public string IdImpuesto { get; set; }
        [Key]
        [Column("forma_pago")]
        [StringLength(2)]
        public string FormaPago { get; set; }
        [Column("importe_pago", TypeName = "numeric(12, 0)")]
        public decimal? ImportePago { get; set; }
        [Column("importe", TypeName = "numeric(12, 0)")]
        public decimal? Importe { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
