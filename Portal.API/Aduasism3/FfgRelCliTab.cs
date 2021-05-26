using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_rel_cli_tab")]
    public partial class FfgRelCliTab
    {
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Required]
        [Column("mex_ame")]
        [StringLength(1)]
        public string MexAme { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
    }
}
