using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("spt_space")]
    public partial class SptSpace
    {
        [Column("name")]
        [StringLength(776)]
        public string Name { get; set; }
        [Column("rows")]
        [StringLength(50)]
        public string Rows { get; set; }
        [Column("reserved")]
        [StringLength(50)]
        public string Reserved { get; set; }
        [Column("data")]
        [StringLength(50)]
        public string Data { get; set; }
        [Column("indexp")]
        [StringLength(50)]
        public string Indexp { get; set; }
        [Column("unused")]
        [StringLength(50)]
        public string Unused { get; set; }
    }
}
