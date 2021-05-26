using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_tab_aduana")]
    public partial class FfgTabAduana
    {
        [Key]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("mex_ame")]
        [StringLength(1)]
        public string MexAme { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
