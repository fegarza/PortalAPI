using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_estados_financieros")]
    public partial class CtEstadosFinanciero
    {
        [Key]
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Key]
        [Column("tipo_reporte")]
        [StringLength(4)]
        public string TipoReporte { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("renglon", TypeName = "decimal(4, 0)")]
        public decimal Renglon { get; set; }
        [Column("font")]
        [StringLength(1)]
        public string Font { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("valor_1", TypeName = "decimal(16, 2)")]
        public decimal? Valor1 { get; set; }
        [Column("valor_2", TypeName = "decimal(16, 2)")]
        public decimal? Valor2 { get; set; }
        [Column("valor_3", TypeName = "decimal(16, 2)")]
        public decimal? Valor3 { get; set; }
        [Column("valor_4", TypeName = "decimal(16, 2)")]
        public decimal? Valor4 { get; set; }
    }
}
