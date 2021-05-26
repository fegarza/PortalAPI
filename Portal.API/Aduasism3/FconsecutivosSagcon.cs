using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivos_sagcon")]
    public partial class FconsecutivosSagcon
    {
        [Column("factura_consol", TypeName = "numeric(7, 0)")]
        public decimal? FacturaConsol { get; set; }
        [Column("sagar", TypeName = "numeric(7, 0)")]
        public decimal? Sagar { get; set; }
    }
}
