using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_nivel_adms")]
    public partial class GgNivelAdm
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("no_modulo")]
        public int NoModulo { get; set; }
        [Column("nivel_adms")]
        public int NivelAdms { get; set; }
    }
}
