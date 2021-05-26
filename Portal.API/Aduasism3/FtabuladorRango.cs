using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftabulador_rangos")]
    public partial class FtabuladorRango
    {
        [Key]
        [Column("id_tipo_cliente")]
        [StringLength(3)]
        public string IdTipoCliente { get; set; }
        [Key]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("limite_superior", TypeName = "numeric(12, 0)")]
        public decimal LimiteSuperior { get; set; }
        [Column("porc_impor", TypeName = "numeric(6, 4)")]
        public decimal PorcImpor { get; set; }
        [Column("porc_expor", TypeName = "numeric(6, 4)")]
        public decimal PorcExpor { get; set; }
        [Column("monto_impor", TypeName = "numeric(11, 2)")]
        public decimal MontoImpor { get; set; }
        [Column("monto_expor", TypeName = "numeric(11, 2)")]
        public decimal MontoExpor { get; set; }
        [Key]
        [Column("no_sec", TypeName = "numeric(3, 0)")]
        public decimal NoSec { get; set; }
    }
}
