using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_det_gasto_comprobar")]
    public partial class CpDetGastoComprobar
    {
        [Key]
        [Column("consecutivo_detalle", TypeName = "numeric(3, 0)")]
        public decimal ConsecutivoDetalle { get; set; }
        [Column("tipo_beneficiario_distribucion")]
        public int TipoBeneficiarioDistribucion { get; set; }
        [Column("num_beneficiario_distribucion", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficiarioDistribucion { get; set; }
        [Required]
        [Column("nombre_beneficiario")]
        [StringLength(59)]
        public string NombreBeneficiario { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Column("num_reembolso", TypeName = "decimal(6, 0)")]
        public decimal? NumReembolso { get; set; }
    }
}
