using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_detalle_ieps")]
    public partial class FpedimentoDetalleIep
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
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("id_impuesto")]
        [StringLength(2)]
        public string IdImpuesto { get; set; }
        [Column("ieps", TypeName = "numeric(10, 5)")]
        public decimal? Ieps { get; set; }
        [Column("tipo_ieps")]
        [StringLength(3)]
        public string TipoIeps { get; set; }
        [Column("ieps_forma_pago")]
        [StringLength(2)]
        public string IepsFormaPago { get; set; }
        [Column("ieps_importe", TypeName = "numeric(12, 0)")]
        public decimal? IepsImporte { get; set; }
        [Column("tasa_ieps")]
        [StringLength(2)]
        public string TasaIeps { get; set; }
        [Column("tipo_moneda_ieps")]
        [StringLength(3)]
        public string TipoMonedaIeps { get; set; }
        [Column("pesos_x_litro", TypeName = "decimal(10, 4)")]
        public decimal? PesosXLitro { get; set; }
        [Column("cantidad_litros", TypeName = "decimal(15, 3)")]
        public decimal? CantidadLitros { get; set; }
    }
}
