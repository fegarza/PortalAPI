using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_factura_proveedor_ajuste")]
    public partial class CpFacturaProveedorAjuste
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
        [Column("cpto_ajuste", TypeName = "numeric(3, 0)")]
        public decimal CptoAjuste { get; set; }
        [Column("tipo_ajuste", TypeName = "numeric(2, 0)")]
        public decimal TipoAjuste { get; set; }
        [Column("valor_bruto_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorBrutoAjuste { get; set; }
        [Column("importe_iva_ajuste", TypeName = "numeric(14, 4)")]
        public decimal? ImporteIvaAjuste { get; set; }
        [Column("por_iva_ajuste", TypeName = "numeric(5, 4)")]
        public decimal? PorIvaAjuste { get; set; }
        [Column("valor_cxp_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxpAjuste { get; set; }
        [Column("fecha_ajuste", TypeName = "datetime")]
        public DateTime? FechaAjuste { get; set; }
        [Column("num_acuse", TypeName = "decimal(10, 0)")]
        public decimal? NumAcuse { get; set; }
    }
}
