using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fremesa_observacion")]
    public partial class FremesaObservacion
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Column("observaciones")]
        [StringLength(120)]
        public string Observaciones { get; set; }
    }
}
