using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_consecu_factura")]
    public partial class FfgConsecuFactura
    {
        [Key]
        [Column("consecutivo_factura", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFactura { get; set; }
    }
}
