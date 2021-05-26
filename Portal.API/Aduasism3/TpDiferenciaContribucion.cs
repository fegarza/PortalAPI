using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_diferencia_contribucion")]
    public partial class TpDiferenciaContribucion
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_diferencia")]
        public short IdDiferencia { get; set; }
        [Column("clave_gravamen")]
        public int ClaveGravamen { get; set; }
        [Column("importe_pago", TypeName = "decimal(12, 0)")]
        public decimal? ImportePago { get; set; }
        [Column("forma_pago")]
        public int? FormaPago { get; set; }
    }
}
