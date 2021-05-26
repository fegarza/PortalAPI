using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("f_log_automail")]
    public partial class FLogAutomail
    {
        [Key]
        [Column("consecutivo")]
        public int Consecutivo { get; set; }
        [Column("destinatarios")]
        [StringLength(100)]
        public string Destinatarios { get; set; }
        [Column("archivos")]
        [StringLength(100)]
        public string Archivos { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
    }
}
