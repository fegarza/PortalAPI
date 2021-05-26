using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_log_contabilidad")]
    public partial class CtLogContabilidad
    {
        [Key]
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal NumDoctoPago { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Key]
        [Column("tipo_documento", TypeName = "numeric(3, 0)")]
        public decimal TipoDocumento { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal? NumBeneficiario { get; set; }
        [Column("num_movimiento", TypeName = "numeric(10, 0)")]
        public decimal? NumMovimiento { get; set; }
        [Column("fecha_movimiento", TypeName = "datetime")]
        public DateTime? FechaMovimiento { get; set; }
        [Column("num_soporte", TypeName = "numeric(6, 0)")]
        public decimal? NumSoporte { get; set; }
        [Column("pantalla_actualiza")]
        [StringLength(10)]
        public string PantallaActualiza { get; set; }
        [Column("tipo_afectacion")]
        [StringLength(1)]
        public string TipoAfectacion { get; set; }
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("tipo_concepto")]
        [StringLength(1)]
        public string TipoConcepto { get; set; }
        [Column("tipo_soporte", TypeName = "numeric(3, 0)")]
        public decimal? TipoSoporte { get; set; }
        [Column("valor_afectar", TypeName = "numeric(16, 4)")]
        public decimal? ValorAfectar { get; set; }
    }
}
