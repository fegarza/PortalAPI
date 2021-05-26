using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_consecutivo_factura")]
    public partial class FfgConsecutivoFactura
    {
        [Column("consecutivo_factura", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFactura { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
