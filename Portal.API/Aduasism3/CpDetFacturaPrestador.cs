using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_factura_prestador")]
    public partial class CpDetFacturaPrestador
    {
        [Key]
        [Column("consecutivo_detalle", TypeName = "numeric(10, 0)")]
        public decimal ConsecutivoDetalle { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal? ValorBruto { get; set; }
        [Column("valor_descuento", TypeName = "numeric(16, 4)")]
        public decimal? ValorDescuento { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("importe_retencion", TypeName = "numeric(14, 4)")]
        public decimal? ImporteRetencion { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Column("por_retencion", TypeName = "numeric(5, 2)")]
        public decimal? PorRetencion { get; set; }
        [Column("por_iva", TypeName = "numeric(5, 2)")]
        public decimal? PorIva { get; set; }
    }
}
