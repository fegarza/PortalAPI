using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_compensacion")]
    public partial class TpCompensacion
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_compensacion")]
        public short IdCompensacion { get; set; }
        [Column("patente_original")]
        public int PatenteOriginal { get; set; }
        [Column("pedimento_original")]
        public int PedimentoOriginal { get; set; }
        [Column("aduana_original")]
        public int AduanaOriginal { get; set; }
        [Column("fecha_pago_original", TypeName = "datetime")]
        public DateTime? FechaPagoOriginal { get; set; }
        [Column("gravamen")]
        public int? Gravamen { get; set; }
        [Column("monto", TypeName = "decimal(12, 2)")]
        public decimal? Monto { get; set; }
    }
}
