using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_no_pedimento")]
    public partial class FconsecutivoNoPedimento
    {
        [Column("consecutivo_no_ped", TypeName = "numeric(6, 0)")]
        public decimal ConsecutivoNoPed { get; set; }
    }
}
