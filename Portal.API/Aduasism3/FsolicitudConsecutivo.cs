using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fsolicitud_consecutivo")]
    [Index(nameof(Rowguid), Name = "index_1997302225", IsUnique = true)]
    public partial class FsolicitudConsecutivo
    {
        [Column("cons_solicitud", TypeName = "numeric(18, 0)")]
        public decimal ConsSolicitud { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
