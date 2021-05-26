using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_movto_contable")]
    public partial class CtMovtoContable
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Key]
        [Column("tipo_poliza")]
        [StringLength(1)]
        public string TipoPoliza { get; set; }
        [Key]
        [Column("consec_poliza", TypeName = "decimal(6, 0)")]
        public decimal ConsecPoliza { get; set; }
        [Key]
        [Column("numero_movto", TypeName = "decimal(6, 0)")]
        public decimal NumeroMovto { get; set; }
        [Column("fecha_contabilizacion", TypeName = "datetime")]
        public DateTime? FechaContabilizacion { get; set; }
        [Column("status_movto", TypeName = "decimal(1, 0)")]
        public decimal StatusMovto { get; set; }
        [Column("total_debito", TypeName = "decimal(16, 2)")]
        public decimal? TotalDebito { get; set; }
        [Column("total_credito", TypeName = "decimal(16, 2)")]
        public decimal? TotalCredito { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("origen_movto", TypeName = "decimal(1, 0)")]
        public decimal? OrigenMovto { get; set; }
        [Column("reversar_movto")]
        [StringLength(1)]
        public string ReversarMovto { get; set; }
        [Column("periodo_reversar", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoReversar { get; set; }
        [Column("id_error")]
        [StringLength(100)]
        public string IdError { get; set; }
    }
}
