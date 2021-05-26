using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_patente_apoderado")]
    [Index(nameof(Rowguid), Name = "index_673593638", IsUnique = true)]
    public partial class FrelPatenteApoderado
    {
        [Key]
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
