using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_factura_contratista_ajuste")]
    public partial class CpFacturaContratistaAjuste
    {
        [Key]
        [Column("num_ajuste", TypeName = "numeric(3, 0)")]
        public decimal NumAjuste { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Key]
        [Column("num_contrato", TypeName = "numeric(8, 0)")]
        public decimal NumContrato { get; set; }
        [Column("cpto_ajuste", TypeName = "numeric(3, 0)")]
        public decimal CptoAjuste { get; set; }
        [Column("tipo_ajuste", TypeName = "numeric(2, 0)")]
        public decimal TipoAjuste { get; set; }
        [Column("valor_bruto_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorBrutoAjuste { get; set; }
        [Column("importe_amortizacion_ajuste", TypeName = "numeric(14, 4)")]
        public decimal? ImporteAmortizacionAjuste { get; set; }
        [Column("importe_iva_ajuste", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIvaAjuste { get; set; }
        [Column("importe_fondo_garantia_ajuste", TypeName = "numeric(14, 4)")]
        public decimal? ImporteFondoGarantiaAjuste { get; set; }
        [Column("por_iva_ajuste", TypeName = "numeric(5, 4)")]
        public decimal? PorIvaAjuste { get; set; }
        [Column("valor_cxp_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxpAjuste { get; set; }
        [Column("fecha_ajuste", TypeName = "datetime")]
        public DateTime? FechaAjuste { get; set; }
        [Column("status_cxp", TypeName = "decimal(1, 0)")]
        public decimal? StatusCxp { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
    }
}
