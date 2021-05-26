using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbmps_figura")]
    public partial class FbmpsFigura
    {
        [Key]
        [Column("id_figura")]
        [StringLength(13)]
        public string IdFigura { get; set; }
        [Required]
        [Column("id_firma")]
        [StringLength(10)]
        public string IdFirma { get; set; }
    }
}
