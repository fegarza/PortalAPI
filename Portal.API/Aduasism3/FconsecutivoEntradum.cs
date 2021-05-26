using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_entrada")]
    public partial class FconsecutivoEntradum
    {
        [Column("consecutivo_entrada", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoEntrada { get; set; }
    }
}
