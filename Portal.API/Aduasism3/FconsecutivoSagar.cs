using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_sagar")]
    public partial class FconsecutivoSagar
    {
        [Column("consecutivo_sagar", TypeName = "numeric(5, 0)")]
        public decimal ConsecutivoSagar { get; set; }
    }
}
