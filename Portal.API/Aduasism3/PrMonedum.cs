using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_moneda")]
    public partial class PrMonedum
    {
        [Key]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(10, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("pais")]
        [StringLength(50)]
        public string Pais { get; set; }
    }
}
