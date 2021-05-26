using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconceptos")]
    public partial class Fconcepto
    {
        [Key]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Required]
        [Column("descripcion_conc")]
        [StringLength(255)]
        public string DescripcionConc { get; set; }
        [Key]
        [Column("cve_ame_mex")]
        [StringLength(1)]
        public string CveAmeMex { get; set; }
        [Column("cve_editable", TypeName = "numeric(1, 0)")]
        public decimal CveEditable { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(1, 0)")]
        public decimal CveComprobable { get; set; }
        [Column("cta_contable")]
        [StringLength(14)]
        public string CtaContable { get; set; }
        [Column("cve_precuenta", TypeName = "numeric(1, 0)")]
        public decimal CvePrecuenta { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Required]
        [Column("afecta_hon")]
        [StringLength(1)]
        public string AfectaHon { get; set; }
        [Column("prioridad_impresion", TypeName = "numeric(3, 0)")]
        public decimal? PrioridadImpresion { get; set; }
        [Column("descripcion2")]
        [StringLength(255)]
        public string Descripcion2 { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("c_ClaveProdServ")]
        [StringLength(8)]
        public string CClaveProdServ { get; set; }
        [Column("DescripcionSAT")]
        [StringLength(250)]
        public string DescripcionSat { get; set; }
        [Column("c_ClaveUnidad")]
        [StringLength(3)]
        public string CClaveUnidad { get; set; }
    }
}
