using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_consecutivo_folio_ame")]
    public partial class FfgConsecutivoFolioAme
    {
        [Column("consecutivo_folio_ame", TypeName = "numeric(7, 0)")]
        public decimal ConsecutivoFolioAme { get; set; }
    }
}
