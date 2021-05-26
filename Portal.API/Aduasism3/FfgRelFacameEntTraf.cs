using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_rel_facame_ent_traf")]
    public partial class FfgRelFacameEntTraf
    {
        [Required]
        [Column("id_factura_ame")]
        [StringLength(10)]
        public string IdFacturaAme { get; set; }
        [Required]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Required]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
    }
}
