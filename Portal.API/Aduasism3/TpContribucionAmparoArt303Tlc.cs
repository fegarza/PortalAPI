using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_contribucion_amparo_art303TLC")]
    public partial class TpContribucionAmparoArt303Tlc
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
        [Column("secuencial_contribucion")]
        public short SecuencialContribucion { get; set; }
        [Column("valor_mercancia_no_originaria", TypeName = "decimal(12, 0)")]
        public decimal? ValorMercanciaNoOriginaria { get; set; }
        [Column("monto_IGI", TypeName = "decimal(12, 0)")]
        public decimal? MontoIgi { get; set; }
    }
}
