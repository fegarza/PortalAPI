using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_tipocambio")]
    public partial class CmTipocambio
    {
        [Key]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(6, 4)")]
        public decimal TipoCambio { get; set; }
        [Key]
        [Column("fecha_cambio", TypeName = "datetime")]
        public DateTime FechaCambio { get; set; }
    }
}
