using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_tipo_cuenta")]
    public partial class TeTipoCuentum
    {
        [Key]
        [Column("tipo_cuenta", TypeName = "decimal(3, 0)")]
        public decimal TipoCuenta { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(60)]
        public string Descripcion { get; set; }
    }
}
