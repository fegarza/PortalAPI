using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconceptos_ame")]
    public partial class FconceptosAme
    {
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("descripcion_conc")]
        [StringLength(255)]
        public string DescripcionConc { get; set; }
        [Column("cve_ame_mex")]
        [StringLength(1)]
        public string CveAmeMex { get; set; }
        [Column("cve_editable", TypeName = "numeric(18, 0)")]
        public decimal? CveEditable { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(18, 0)")]
        public decimal? CveComprobable { get; set; }
        [Column("cta_contable")]
        [StringLength(14)]
        public string CtaContable { get; set; }
        [Column("cve_precuenta", TypeName = "numeric(18, 0)")]
        public decimal? CvePrecuenta { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(8)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("afecta_hon")]
        [StringLength(10)]
        public string AfectaHon { get; set; }
        [Column("prioridad_impresion", TypeName = "numeric(18, 0)")]
        public decimal? PrioridadImpresion { get; set; }
    }
}
