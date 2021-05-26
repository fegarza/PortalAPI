using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_monedas")]
    public partial class CmMoneda
    {
        [Key]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
        [Column("pais")]
        [StringLength(25)]
        public string Pais { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(6, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("fecha_tipocambio", TypeName = "datetime")]
        public DateTime? FechaTipocambio { get; set; }
        [Column("moneda_base")]
        public short? MonedaBase { get; set; }
    }
}
