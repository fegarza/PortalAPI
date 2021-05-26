using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftrading_americana")]
    public partial class FtradingAmericana
    {
        [Key]
        [Column("cta_gas")]
        [StringLength(10)]
        public string CtaGas { get; set; }
        [Column("folio")]
        [StringLength(10)]
        public string Folio { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("cliente")]
        [StringLength(4)]
        public string Cliente { get; set; }
        [Column("trafico")]
        [StringLength(10)]
        public string Trafico { get; set; }
        [Column("rectificacion")]
        public int? Rectificacion { get; set; }
        [Column("fecha_tra", TypeName = "datetime")]
        public DateTime? FechaTra { get; set; }
        [Column("factura")]
        [StringLength(15)]
        public string Factura { get; set; }
        [Column("valor", TypeName = "numeric(9, 2)")]
        public decimal? Valor { get; set; }
        [Column("peso", TypeName = "numeric(9, 2)")]
        public decimal? Peso { get; set; }
        [Column("des_cta")]
        [StringLength(40)]
        public string DesCta { get; set; }
        [Column("tarifa")]
        [StringLength(40)]
        public string Tarifa { get; set; }
        [Column("comentario")]
        [StringLength(40)]
        public string Comentario { get; set; }
        [Column("anticipo")]
        [StringLength(10)]
        public string Anticipo { get; set; }
        [Column("fecha_ant", TypeName = "datetime")]
        public DateTime? FechaAnt { get; set; }
        [Column("sub_total", TypeName = "numeric(9, 2)")]
        public decimal? SubTotal { get; set; }
        [Column("imp_ant", TypeName = "numeric(9, 2)")]
        public decimal? ImpAnt { get; set; }
        [Column("importe", TypeName = "numeric(9, 2)")]
        public decimal? Importe { get; set; }
        [Column("saldo_cg", TypeName = "numeric(9, 2)")]
        public decimal? SaldoCg { get; set; }
        [Column("poliza")]
        [StringLength(10)]
        public string Poliza { get; set; }
        [Column("fecha_imp", TypeName = "datetime")]
        public DateTime? FechaImp { get; set; }
        [Column("ref_pago")]
        [StringLength(10)]
        public string RefPago { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        [Column("imp_pago", TypeName = "numeric(9, 2)")]
        public decimal? ImpPago { get; set; }
        [Column("cancelada", TypeName = "datetime")]
        public DateTime? Cancelada { get; set; }
        [Column("poliza_can")]
        [StringLength(10)]
        public string PolizaCan { get; set; }
        [Column("can_por")]
        [StringLength(3)]
        public string CanPor { get; set; }
        [Column("tot_ppcc", TypeName = "numeric(9, 2)")]
        public decimal? TotPpcc { get; set; }
        [Column("tot_tfs", TypeName = "numeric(9, 2)")]
        public decimal? TotTfs { get; set; }
        [Column("pc_usa")]
        [StringLength(1)]
        public string PcUsa { get; set; }
        [Column("flete_usa")]
        [StringLength(15)]
        public string FleteUsa { get; set; }
        [Column("fflete_usa", TypeName = "datetime")]
        public DateTime? FfleteUsa { get; set; }
        [Column("iflete_usa", TypeName = "numeric(9, 2)")]
        public decimal? IfleteUsa { get; set; }
        [Column("lflete_usa")]
        [StringLength(30)]
        public string LfleteUsa { get; set; }
        [Column("pc_mex")]
        [StringLength(1)]
        public string PcMex { get; set; }
        [Column("flete_mex")]
        [StringLength(15)]
        public string FleteMex { get; set; }
        [Column("fflete_mex", TypeName = "datetime")]
        public DateTime? FfleteMex { get; set; }
        [Column("iflete_mex", TypeName = "numeric(9, 2)")]
        public decimal? IfleteMex { get; set; }
        [Column("lflete_mex")]
        [StringLength(30)]
        public string LfleteMex { get; set; }
        [Column("cta_tra", TypeName = "datetime")]
        public DateTime? CtaTra { get; set; }
        [Column("can_tra", TypeName = "datetime")]
        public DateTime? CanTra { get; set; }
        [Column("orden_sal")]
        [StringLength(10)]
        public string OrdenSal { get; set; }
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
