using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("se_modulos")]
    public partial class SeModulo
    {
        [Key]
        [Column("mod_id")]
        [StringLength(3)]
        public string ModId { get; set; }
        [Column("mod_nm")]
        [StringLength(30)]
        public string ModNm { get; set; }
    }
}
