using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_calculo")]
    public partial class FtipoCalculo
    {
        [Key]
        [Column("id_tipo_calculo")]
        [StringLength(3)]
        public string IdTipoCalculo { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("select_1")]
        [StringLength(255)]
        public string Select1 { get; set; }
        [Column("select_2")]
        [StringLength(255)]
        public string Select2 { get; set; }
        [Column("where_1")]
        [StringLength(255)]
        public string Where1 { get; set; }
        [Column("where_2")]
        [StringLength(255)]
        public string Where2 { get; set; }
        [Key]
        [Column("cve_mex_ame")]
        [StringLength(1)]
        public string CveMexAme { get; set; }
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
        [Column("select_exp1")]
        [StringLength(255)]
        public string SelectExp1 { get; set; }
        [Column("where_exp1")]
        [StringLength(255)]
        public string WhereExp1 { get; set; }
        [Column("reestriccion_1")]
        [StringLength(1)]
        public string Reestriccion1 { get; set; }
        [Column("reestriccion_2")]
        [StringLength(1)]
        public string Reestriccion2 { get; set; }
        [Column("peso_limite", TypeName = "numeric(14, 3)")]
        public decimal? PesoLimite { get; set; }
        [Column("monto_limite", TypeName = "numeric(12, 2)")]
        public decimal? MontoLimite { get; set; }
        [Column("cantidad_limite", TypeName = "numeric(3, 0)")]
        public decimal? CantidadLimite { get; set; }
        [Column("porcentaje_limite", TypeName = "decimal(7, 4)")]
        public decimal? PorcentajeLimite { get; set; }
        [Column("reestriccion_3")]
        [StringLength(1)]
        public string Reestriccion3 { get; set; }
        [Column("dias_limite", TypeName = "numeric(4, 0)")]
        public decimal? DiasLimite { get; set; }
        [Column("monto_dia", TypeName = "decimal(12, 2)")]
        public decimal? MontoDia { get; set; }
    }
}
