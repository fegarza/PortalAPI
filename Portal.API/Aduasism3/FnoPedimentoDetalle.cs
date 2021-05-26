using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fno_pedimento_detalle")]
    public partial class FnoPedimentoDetalle
    {
        [Key]
        [Column("id_documento")]
        [StringLength(10)]
        public string IdDocumento { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(18, 0)")]
        public decimal Secuencial { get; set; }
        [Column("clave_impuesto")]
        [StringLength(6)]
        public string ClaveImpuesto { get; set; }
        [Column("forma_pago")]
        [StringLength(2)]
        public string FormaPago { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Importe { get; set; }
    }
}
