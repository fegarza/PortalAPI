using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fprofepa_tipo_documento")]
    [Index(nameof(Rowguid), Name = "index_573297152", IsUnique = true)]
    public partial class FprofepaTipoDocumento
    {
        [Column("tipo_doc")]
        [StringLength(2)]
        public string TipoDoc { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
