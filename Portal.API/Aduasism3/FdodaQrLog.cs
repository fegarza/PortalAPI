using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr_logs")]
    public partial class FdodaQrLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Column("numIntegracion")]
        [StringLength(50)]
        public string NumIntegracion { get; set; }
        [Column("mensaje")]
        [StringLength(300)]
        public string Mensaje { get; set; }
        [Column("fecha_MSA", TypeName = "datetime")]
        public DateTime? FechaMsa { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
    }
}
