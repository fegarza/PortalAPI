using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_patente_corresponsal")]
    public partial class FcovePatenteCorresponsal
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("patente")]
        [StringLength(13)]
        public string Patente { get; set; }
    }
}
