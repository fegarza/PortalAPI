using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_control")]
    public partial class FconsecutivoControl
    {
        [Column("consecutivo_control", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoControl { get; set; }
    }
}
