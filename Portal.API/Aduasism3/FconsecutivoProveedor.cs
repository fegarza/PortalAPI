using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_proveedor")]
    public partial class FconsecutivoProveedor
    {
        [Column("consecutivo_proveedor", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoProveedor { get; set; }
    }
}
