using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("pbcatfmt")]
    public partial class Pbcatfmt
    {
        [Required]
        [Column("pbf_name")]
        [StringLength(30)]
        public string PbfName { get; set; }
        [Required]
        [Column("pbf_frmt")]
        [StringLength(254)]
        public string PbfFrmt { get; set; }
        [Column("pbf_type")]
        public short PbfType { get; set; }
        [Column("pbf_cntr")]
        public int? PbfCntr { get; set; }
    }
}
