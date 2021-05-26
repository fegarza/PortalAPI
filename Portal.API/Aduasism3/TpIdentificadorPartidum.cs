using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_identificador_partida")]
    public partial class TpIdentificadorPartidum
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
        [Column("secuencial_identificador")]
        public short SecuencialIdentificador { get; set; }
        [Column("clave_identificador")]
        [StringLength(2)]
        public string ClaveIdentificador { get; set; }
        [Column("complemento1")]
        [StringLength(20)]
        public string Complemento1 { get; set; }
        [Column("complemento2")]
        [StringLength(30)]
        public string Complemento2 { get; set; }
        [Column("complemento3")]
        [StringLength(40)]
        public string Complemento3 { get; set; }
    }
}
