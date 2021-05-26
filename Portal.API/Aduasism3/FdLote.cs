using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fd_lotes")]
    public partial class FdLote
    {
        [Key]
        [Column("LOTE")]
        [StringLength(10)]
        public string Lote { get; set; }
        [Key]
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Key]
        [Column(TypeName = "numeric(3, 0)")]
        public decimal N1 { get; set; }
        [Column("ID_ENTRADA")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("CANTIDAD", TypeName = "numeric(8, 0)")]
        public decimal? Cantidad { get; set; }
        [Column("ONHAND", TypeName = "numeric(8, 0)")]
        public decimal? Onhand { get; set; }
        [Column("ID_UNIDAD")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Column("DETALLE")]
        [StringLength(80)]
        public string Detalle { get; set; }
        [Column("BL")]
        [StringLength(10)]
        public string Bl { get; set; }
        [Column("LOTEANT")]
        [StringLength(10)]
        public string Loteant { get; set; }
        [Column("N1ANT", TypeName = "numeric(3, 0)")]
        public decimal? N1ant { get; set; }
    }
}
