using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_tasa")]
    public partial class TpTasa
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_tasa")]
        public short IdTasa { get; set; }
        [Column("contribucion")]
        public int? Contribucion { get; set; }
        [Column("tipo_tasa")]
        public int? TipoTasa { get; set; }
        [Column("tasa_aplicable", TypeName = "decimal(9, 6)")]
        public decimal? TasaAplicable { get; set; }
        [Column("forma_pago")]
        public int? FormaPago { get; set; }
        [Column("importe", TypeName = "decimal(12, 0)")]
        public decimal? Importe { get; set; }
    }
}
