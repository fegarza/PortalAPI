using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_envio")]
    public partial class FtipoEnvio
    {
        [Key]
        [Column("id_tipo")]
        [StringLength(1)]
        public string IdTipo { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
    }
}
