using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_moneda")]
    public partial class OcMonedum
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("id_moneda_agente")]
        [StringLength(4)]
        public string IdMonedaAgente { get; set; }
        [Column("importe_limite", TypeName = "decimal(15, 2)")]
        public decimal ImporteLimite { get; set; }
        [Required]
        [Column("moneda_activa")]
        public bool? MonedaActiva { get; set; }
    }
}
