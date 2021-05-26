using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_factura")]
    public partial class FconsecutivoFactura
    {
        [Column("consecutivo_factura", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFactura { get; set; }
        [Column("prefijo")]
        [StringLength(6)]
        public string Prefijo { get; set; }
    }
}
