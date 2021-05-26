using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_formatos_informes")]
    public partial class CtFormatosInforme
    {
        [Key]
        [Column("tipo_formato")]
        [StringLength(1)]
        public string TipoFormato { get; set; }
        [Key]
        [Column("cve_formato", TypeName = "decimal(2, 0)")]
        public decimal CveFormato { get; set; }
        [Key]
        [Column("numero_renglon", TypeName = "decimal(3, 0)")]
        public decimal NumeroRenglon { get; set; }
        [Required]
        [Column("descr_formato")]
        [StringLength(60)]
        public string DescrFormato { get; set; }
        [Required]
        [Column("tipo_impresion")]
        [StringLength(1)]
        public string TipoImpresion { get; set; }
        [Required]
        [Column("formato_impresion")]
        [StringLength(20)]
        public string FormatoImpresion { get; set; }
        [Column("offset_columna", TypeName = "decimal(3, 0)")]
        public decimal OffsetColumna { get; set; }
    }
}
