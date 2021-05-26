using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fprofepa_estados")]
    [Index(nameof(Rowguid), Name = "index_493296867", IsUnique = true)]
    public partial class FprofepaEstado
    {
        [Column("cve_estado")]
        [StringLength(2)]
        public string CveEstado { get; set; }
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("C733CVEREG")]
        [StringLength(2)]
        public string C733cvereg { get; set; }
        [Column("C733EDO")]
        [StringLength(3)]
        public string C733edo { get; set; }
        [Column("abreviado")]
        [StringLength(2)]
        public string Abreviado { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
