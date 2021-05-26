using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_reembolso")]
    public partial class CpDetReembolso
    {
        [Required]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("num_factura_soporte", TypeName = "numeric(6, 0)")]
        public decimal NumFacturaSoporte { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("valor_bruto", TypeName = "numeric(16, 4)")]
        public decimal? ValorBruto { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "decimal(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("num_reembolso", TypeName = "decimal(6, 0)")]
        public decimal NumReembolso { get; set; }
        [Column("importe_iva", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIva { get; set; }
        [Column("importe_retencion", TypeName = "numeric(14, 4)")]
        public decimal? ImporteRetencion { get; set; }
        [Column("por_iva", TypeName = "numeric(5, 2)")]
        public decimal? PorIva { get; set; }
        [Column("por_retencion", TypeName = "numeric(5, 2)")]
        public decimal? PorRetencion { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Key]
        [Column("consecutivo_detalle", TypeName = "numeric(3, 0)")]
        public decimal ConsecutivoDetalle { get; set; }
        [Column("tipo_ref")]
        [StringLength(1)]
        public string TipoRef { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
    }
}
