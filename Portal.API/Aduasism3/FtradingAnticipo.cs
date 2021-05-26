using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftrading_anticipo")]
    public partial class FtradingAnticipo
    {
        [Key]
        [Column("referencia")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Key]
        [Column("transferencia")]
        [StringLength(10)]
        public string Transferencia { get; set; }
        [Key]
        [Column("anticipo", TypeName = "numeric(11, 2)")]
        public decimal Anticipo { get; set; }
    }
}
