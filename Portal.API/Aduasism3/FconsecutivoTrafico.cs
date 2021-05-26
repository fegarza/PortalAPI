using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_trafico")]
    public partial class FconsecutivoTrafico
    {
        [Column("consecutivo_trafico", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoTrafico { get; set; }
    }
}
