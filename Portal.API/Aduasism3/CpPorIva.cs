using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_por_iva")]
    public partial class CpPorIva
    {
        [Key]
        [Column("id", TypeName = "decimal(6, 3)")]
        public decimal Id { get; set; }
        [Column("porcentaje_iva", TypeName = "decimal(6, 3)")]
        public decimal PorcentajeIva { get; set; }
        [Column("iva_pag_num_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaPagNumCta { get; set; }
        [Column("iva_pag_sub_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaPagSubCta { get; set; }
        [Column("iva_pag_sub_subcta", TypeName = "decimal(4, 0)")]
        public decimal? IvaPagSubSubcta { get; set; }
        [Column("iva_acr_num_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaAcrNumCta { get; set; }
        [Column("iva_acr_sub_cta", TypeName = "decimal(4, 0)")]
        public decimal? IvaAcrSubCta { get; set; }
        [Column("iva_acr_sub_subcta", TypeName = "decimal(4, 0)")]
        public decimal? IvaAcrSubSubcta { get; set; }
        [Column("porc_iva", TypeName = "decimal(6, 3)")]
        public decimal? PorcIva { get; set; }
        [Column("c_tipo_factor")]
        [StringLength(20)]
        public string CTipoFactor { get; set; }
    }
}
