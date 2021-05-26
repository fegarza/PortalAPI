using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_manifestacion")]
    public partial class FconsecutivoManifestacion
    {
        [Column("consecutivo", TypeName = "numeric(7, 0)")]
        public decimal Consecutivo { get; set; }
    }
}
