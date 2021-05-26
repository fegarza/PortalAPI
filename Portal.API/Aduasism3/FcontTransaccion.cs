using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fcont_transaccion")]
    public partial class FcontTransaccion
    {
        [Column("id_trans", TypeName = "numeric(18, 0)")]
        public decimal? IdTrans { get; set; }
    }
}
