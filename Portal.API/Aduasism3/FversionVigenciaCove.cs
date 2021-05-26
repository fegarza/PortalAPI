using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fversion_vigencia_cove")]
    public partial class FversionVigenciaCove
    {
        [Key]
        [Column("version")]
        [StringLength(100)]
        public string Version { get; set; }
        [Column("tipo_version")]
        [StringLength(1)]
        public string TipoVersion { get; set; }
        [Column("fecha_vigencia", TypeName = "datetime")]
        public DateTime? FechaVigencia { get; set; }
    }
}
