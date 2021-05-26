using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class VwCpStatusDcto
    {
        [Column("tipo_beneficiario", TypeName = "decimal(10, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(10, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("num_documento", TypeName = "numeric(10, 0)")]
        public decimal NumDocumento { get; set; }
        [Column("tipo_documento", TypeName = "numeric(18, 0)")]
        public decimal? TipoDocumento { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Column("valor_cxp_ajuste", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxpAjuste { get; set; }
        [Column("status_cxp", TypeName = "decimal(1, 0)")]
        public decimal? StatusCxp { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Required]
        [Column("nombre_beneficiario")]
        [StringLength(50)]
        public string NombreBeneficiario { get; set; }
        [Column("numproy")]
        public int? Numproy { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
