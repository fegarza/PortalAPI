using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_ferrocarril")]
    public partial class FconsecutivoFerrocarril
    {
        [Column("consecutivo_ferrocarril", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFerrocarril { get; set; }
    }
}
