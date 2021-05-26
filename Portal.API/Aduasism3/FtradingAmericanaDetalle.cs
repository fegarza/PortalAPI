using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftrading_americana_detalle")]
    public partial class FtradingAmericanaDetalle
    {
        [Key]
        [Column("cta_gas")]
        [StringLength(10)]
        public string CtaGas { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("cliente")]
        [StringLength(5)]
        public string Cliente { get; set; }
        [Column("trafico")]
        [StringLength(10)]
        public string Trafico { get; set; }
        [Key]
        [Column("cve_mov")]
        [StringLength(2)]
        public string CveMov { get; set; }
        [Column("importe", TypeName = "numeric(9, 2)")]
        public decimal? Importe { get; set; }
        [Column("des_mov")]
        [StringLength(40)]
        public string DesMov { get; set; }
        [Column("usuario")]
        [StringLength(3)]
        public string Usuario { get; set; }
        [Column("fua", TypeName = "datetime")]
        public DateTime? Fua { get; set; }
        [Column("hua")]
        [StringLength(8)]
        public string Hua { get; set; }
    }
}
