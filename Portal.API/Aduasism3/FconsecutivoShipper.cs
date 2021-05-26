using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconsecutivo_shipper")]
    public partial class FconsecutivoShipper
    {
        [Key]
        [Column("consecutivo_shipper", TypeName = "numeric(8, 0)")]
        public decimal ConsecutivoShipper { get; set; }
    }
}
