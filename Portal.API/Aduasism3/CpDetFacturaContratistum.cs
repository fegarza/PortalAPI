using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_factura_contratista")]
    public partial class CpDetFacturaContratistum
    {
        [Key]
        [Column("consecutivo_detalle", TypeName = "numeric(10, 0)")]
        public decimal ConsecutivoDetalle { get; set; }
        [Column("num_estimacion", TypeName = "decimal(10, 0)")]
        public decimal NumEstimacion { get; set; }
        [Required]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal ValorBruto { get; set; }
        [Column("importe_amortizacion", TypeName = "numeric(14, 4)")]
        public decimal? ImporteAmortizacion { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal ImporteIva { get; set; }
        [Column("importe_fondo_garantia", TypeName = "numeric(14, 4)")]
        public decimal? ImporteFondoGarantia { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("num_contrato", TypeName = "decimal(8, 0)")]
        public decimal NumContrato { get; set; }
        [Column("por_iva", TypeName = "numeric(5, 2)")]
        public decimal? PorIva { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Column("saldo_cxp", TypeName = "numeric(16, 4)")]
        public decimal? SaldoCxp { get; set; }
        [Column("status_cxp", TypeName = "decimal(1, 0)")]
        public decimal? StatusCxp { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal? StatusContable { get; set; }
    }
}
