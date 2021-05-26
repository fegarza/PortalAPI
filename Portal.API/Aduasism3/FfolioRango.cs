using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffolio_rango")]
    public partial class FfolioRango
    {
        [Key]
        [Column("id_anio", TypeName = "numeric(4, 0)")]
        public decimal IdAnio { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Key]
        [Column("pedimento_inicial")]
        [StringLength(7)]
        public string PedimentoInicial { get; set; }
        [Required]
        [Column("pedimento_final")]
        [StringLength(7)]
        public string PedimentoFinal { get; set; }
    }
}
