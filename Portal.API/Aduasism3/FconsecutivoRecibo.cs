using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_recibo")]
    public partial class FconsecutivoRecibo
    {
        [Column("consecutivo_recibo", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoRecibo { get; set; }
    }
}
