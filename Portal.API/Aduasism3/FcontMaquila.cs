using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fcont_maquila")]
    public partial class FcontMaquila
    {
        [Column("contador_maquila", TypeName = "numeric(3, 0)")]
        public decimal ContadorMaquila { get; set; }
    }
}
