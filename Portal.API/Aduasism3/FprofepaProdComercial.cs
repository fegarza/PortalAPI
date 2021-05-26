using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fprofepa_prod_comercial")]
    [Index(nameof(Rowguid), Name = "index_557297095", IsUnique = true)]
    public partial class FprofepaProdComercial
    {
        [Column("C734CVE")]
        [StringLength(4)]
        public string C734cve { get; set; }
        [Column("C734CIENT")]
        [StringLength(60)]
        public string C734cient { get; set; }
        [Column("C734NUMCOM")]
        [StringLength(9)]
        public string C734numcom { get; set; }
        [Column("C734ID")]
        [StringLength(5)]
        public string C734id { get; set; }
        [Column("C734FAMILI")]
        [StringLength(20)]
        public string C734famili { get; set; }
        [Column("C734NOMCOM")]
        [StringLength(60)]
        public string C734nomcom { get; set; }
        [Column("C734AAANID")]
        public double? C734aaanid { get; set; }
        [Column("C734AAACID")]
        [StringLength(10)]
        public string C734aaacid { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
