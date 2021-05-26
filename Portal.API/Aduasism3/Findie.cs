using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FINDICE")]
    public partial class Findie
    {
        [Key]
        [Column("id_anio")]
        [StringLength(4)]
        public string IdAnio { get; set; }
        [Key]
        [Column("id_mes")]
        [StringLength(2)]
        public string IdMes { get; set; }
        [Column("indice", TypeName = "numeric(10, 5)")]
        public decimal Indice { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
    }
}
