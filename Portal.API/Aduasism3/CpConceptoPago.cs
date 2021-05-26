using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_concepto_pago")]
    public partial class CpConceptoPago
    {
        [Key]
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("tipo_concepto", TypeName = "numeric(1, 0)")]
        public decimal? TipoConcepto { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("por_iva", TypeName = "numeric(4, 2)")]
        public decimal? PorIva { get; set; }
        [Column("por_retencion", TypeName = "numeric(4, 2)")]
        public decimal? PorRetencion { get; set; }
        [Column("por_retencion_iva", TypeName = "decimal(5, 2)")]
        public decimal? PorRetencionIva { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(1, 0)")]
        public decimal? CveComprobable { get; set; }
        [Column("cve_ame_mex")]
        [StringLength(1)]
        public string CveAmeMex { get; set; }
        [Column("cve_precuenta", TypeName = "numeric(1, 0)")]
        public decimal? CvePrecuenta { get; set; }
        [Column("cve_editable", TypeName = "numeric(1, 0)")]
        public decimal? CveEditable { get; set; }
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Column("fecha_modificacion", TypeName = "datetime")]
        public DateTime? FechaModificacion { get; set; }
        [Column("cve_tmsf")]
        public int? CveTmsf { get; set; }
        [Column("c_tipo_factor")]
        [StringLength(20)]
        public string CTipoFactor { get; set; }
    }
}
