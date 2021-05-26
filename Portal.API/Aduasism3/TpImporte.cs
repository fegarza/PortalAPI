using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_importe")]
    public partial class TpImporte
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("partida")]
        public int Partida { get; set; }
        [Key]
        [Column("numero_partida")]
        public int NumeroPartida { get; set; }
        [Key]
        [Column("secuencial_gravamen")]
        public short SecuencialGravamen { get; set; }
        [Key]
        [Column("secuencial_importe")]
        public short SecuencialImporte { get; set; }
        [Column("forma_pago")]
        public int? FormaPago { get; set; }
        [Column("importe", TypeName = "decimal(12, 0)")]
        public decimal? Importe { get; set; }
    }
}
