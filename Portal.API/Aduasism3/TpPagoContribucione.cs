using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_pago_contribuciones")]
    public partial class TpPagoContribucione
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_determinacion")]
        public short IdDeterminacion { get; set; }
        [Key]
        [Column("id_pago")]
        public short IdPago { get; set; }
        [Column("gravamen")]
        public int? Gravamen { get; set; }
        [Column("forma_pago")]
        public int? FormaPago { get; set; }
        [Column("importe", TypeName = "decimal(12, 2)")]
        public decimal? Importe { get; set; }
    }
}
