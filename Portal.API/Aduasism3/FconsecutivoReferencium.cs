using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_referencia")]
    public partial class FconsecutivoReferencium
    {
        [Column("consecutivo_referencia", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoReferencia { get; set; }
    }
}
