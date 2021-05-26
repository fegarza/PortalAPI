using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_cptos_costos")]
    public partial class CoCptosCosto
    {
        [Key]
        [Column("cve_concepto", TypeName = "numeric(4, 0)")]
        public decimal CveConcepto { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("status_concepto")]
        [StringLength(1)]
        public string StatusConcepto { get; set; }
        [Required]
        [Column("relacion")]
        [StringLength(20)]
        public string Relacion { get; set; }
        [Required]
        [Column("tipo_concepto")]
        [StringLength(2)]
        public string TipoConcepto { get; set; }
    }
}
