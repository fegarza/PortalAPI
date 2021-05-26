using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_tasa_partida")]
    public partial class TpTasaPartidum
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
        [Column("secuencial_tasa")]
        public short SecuencialTasa { get; set; }
        [Column("tipo_tasa")]
        public int? TipoTasa { get; set; }
        [Column("tasa_aplicable", TypeName = "decimal(9, 6)")]
        public decimal? TasaAplicable { get; set; }
    }
}
