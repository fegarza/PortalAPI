using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class ViewRegistroShcp516
    {
        [Required]
        [Column("referencia")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Column("rectificacion", TypeName = "decimal(1, 0)")]
        public decimal Rectificacion { get; set; }
        [Column("secuencial")]
        public int? Secuencial { get; set; }
        [Column("registroSecuencia")]
        public int? RegistroSecuencia { get; set; }
        [Required]
        [Column("registroValidacion")]
        [StringLength(41)]
        public string RegistroValidacion { get; set; }
    }
}
