using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_mercancia")]
    [Index(nameof(Rowguid), Name = "index_1495728431", IsUnique = true)]
    public partial class FpedimentoMercancium
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
        [Column("serie")]
        [StringLength(25)]
        public string Serie { get; set; }
        [Column("kilometraje", TypeName = "numeric(5, 0)")]
        public decimal? Kilometraje { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("secuencial_vin", TypeName = "numeric(5, 0)")]
        public decimal? SecuencialVin { get; set; }
    }
}
