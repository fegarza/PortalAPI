using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_folio_entrada")]
    public partial class FconsecutivoFolioEntradum
    {
        [Column("folio", TypeName = "numeric(7, 0)")]
        public decimal Folio { get; set; }
    }
}
