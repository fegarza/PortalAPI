using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_fecha_consulta_bl")]
    public partial class FdespachoFechaConsultaBl
    {
        [Key]
        [Column("fecha", TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Key]
        [Column("aduana")]
        [StringLength(3)]
        public string Aduana { get; set; }
    }
}
