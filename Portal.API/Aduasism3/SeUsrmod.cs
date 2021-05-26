using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("se_usrmod")]
    public partial class SeUsrmod
    {
        [Required]
        [Column("usr_id")]
        [StringLength(8)]
        public string UsrId { get; set; }
        [Required]
        [Column("mod_id")]
        [StringLength(3)]
        public string ModId { get; set; }
    }
}
