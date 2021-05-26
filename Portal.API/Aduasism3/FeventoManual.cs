using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fevento_manual")]
    public partial class FeventoManual
    {
        [Key]
        [Column("id_evento")]
        [StringLength(25)]
        public string IdEvento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(25)]
        public string Descripcion { get; set; }
        [Column("observaciones")]
        [StringLength(60)]
        public string Observaciones { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
