using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frelacion_documentos_det_full")]
    public partial class FrelacionDocumentosDetFull
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(9, 0)")]
        public decimal Secuencial { get; set; }
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
    }
}
