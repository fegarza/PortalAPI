using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_detalle_303")]
    [Index(nameof(Rowguid), Name = "index_791009899", IsUnique = true)]
    public partial class FpedimentoDetalle303
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
        [Column("valor_mcia_no_originarias", TypeName = "numeric(12, 0)")]
        public decimal ValorMciaNoOriginarias { get; set; }
        [Column("monto_igi", TypeName = "numeric(12, 0)")]
        public decimal MontoIgi { get; set; }
        [Required]
        [Column("forma_pago")]
        [StringLength(2)]
        public string FormaPago { get; set; }
        [Column("porcentaje", TypeName = "numeric(5, 2)")]
        public decimal Porcentaje { get; set; }
        [Column("importe_mn", TypeName = "numeric(12, 0)")]
        public decimal ImporteMn { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
