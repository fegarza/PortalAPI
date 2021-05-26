using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsectores")]
    public partial class Fsectore
    {
        [Key]
        [Column("id_sector")]
        [StringLength(3)]
        public string IdSector { get; set; }
        [Key]
        [Column("cve_tipo_ope")]
        [StringLength(1)]
        public string CveTipoOpe { get; set; }
        [Column("sector")]
        [StringLength(1000)]
        public string Sector { get; set; }
    }
}
