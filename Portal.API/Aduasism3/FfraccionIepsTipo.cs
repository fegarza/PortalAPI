using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_ieps_tipos")]
    public partial class FfraccionIepsTipo
    {
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Column("tasa", TypeName = "decimal(12, 4)")]
        public decimal? Tasa { get; set; }
        [Column("tipo")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("tipo_moneda")]
        [StringLength(3)]
        public string TipoMoneda { get; set; }
        [Column("nombre", TypeName = "text")]
        public string Nombre { get; set; }
    }
}
