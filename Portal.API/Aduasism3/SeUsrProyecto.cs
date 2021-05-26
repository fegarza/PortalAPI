using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("se_usr_proyecto")]
    public partial class SeUsrProyecto
    {
        [Key]
        [Column("usr_id")]
        [StringLength(8)]
        public string UsrId { get; set; }
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("tipo_pr")]
        [StringLength(1)]
        public string TipoPr { get; set; }
    }
}
