using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cp_orden_pago_ajuste")]
    public partial class CpOrdenPagoAjuste
    {
        [Column("num_ajuste", TypeName = "numeric(3, 0)")]
        public decimal NumAjuste { get; set; }
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("cpto_ajuste", TypeName = "numeric(3, 0)")]
        public decimal CptoAjuste { get; set; }
        [Column("tipo_ajuste", TypeName = "numeric(1, 0)")]
        public decimal? TipoAjuste { get; set; }
        [Column("valor_bruto_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorBrutoAjuste { get; set; }
        [Column("importe_iva_ajuste", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIvaAjuste { get; set; }
        [Column("valor_cxp_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxpAjuste { get; set; }
        [Column("por_iva_ajuste", TypeName = "numeric(5, 4)")]
        public decimal? PorIvaAjuste { get; set; }
        [Column("fecha_ajuste", TypeName = "datetime")]
        public DateTime? FechaAjuste { get; set; }
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("referencia_ajuste")]
        [StringLength(255)]
        public string ReferenciaAjuste { get; set; }
        [Column("poliza_contable", TypeName = "decimal(6, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
    }
}
