using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_log_costos")]
    public partial class CoLogCosto
    {
        [Key]
        [Column("consecutivo_movimiento", TypeName = "numeric(10, 0)")]
        public decimal ConsecutivoMovimiento { get; set; }
        [Required]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("fecha_movimiento", TypeName = "datetime")]
        public DateTime FechaMovimiento { get; set; }
        [Required]
        [Column("tipo_concepto")]
        [StringLength(2)]
        public string TipoConcepto { get; set; }
        [Column("tipo_documento")]
        [StringLength(10)]
        public string TipoDocumento { get; set; }
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal? NumDocumento { get; set; }
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal? NumBeneficiario { get; set; }
        [Column("tipo_soporte", TypeName = "numeric(3, 0)")]
        public decimal? TipoSoporte { get; set; }
        [Column("num_soporte", TypeName = "numeric(6, 0)")]
        public decimal? NumSoporte { get; set; }
        [Required]
        [Column("tipo_afectacion")]
        [StringLength(1)]
        public string TipoAfectacion { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("proceso_actualiza")]
        [StringLength(255)]
        public string ProcesoActualiza { get; set; }
        [Column("cve_concepto", TypeName = "numeric(4, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("valor_afectacion", TypeName = "decimal(16, 2)")]
        public decimal ValorAfectacion { get; set; }
    }
}
