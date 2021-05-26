using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("gg_dwcampos_copy")]
    [Index(nameof(Dwname), nameof(Numcolumn), Name = "gg_dwcampos_x", IsUnique = true)]
    public partial class GgDwcamposCopy
    {
        [Required]
        [Column("dwname")]
        [StringLength(50)]
        public string Dwname { get; set; }
        [Column("numcolumn")]
        public int Numcolumn { get; set; }
        [Required]
        [Column("fieldname")]
        [StringLength(50)]
        public string Fieldname { get; set; }
        [Column("required")]
        public int Required { get; set; }
        [Column("path_help")]
        [StringLength(100)]
        public string PathHelp { get; set; }
    }
}
