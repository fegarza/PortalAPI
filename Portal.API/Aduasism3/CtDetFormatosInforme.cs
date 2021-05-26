using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_det_formatos_informes")]
    public partial class CtDetFormatosInforme
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
        [Key]
        [Column("consec_renglon", TypeName = "decimal(3, 0)")]
        public decimal ConsecRenglon { get; set; }
        [Required]
        [Column("operacion")]
        [StringLength(1)]
        public string Operacion { get; set; }
        [Required]
        [Column("tipo_renglon")]
        [StringLength(1)]
        public string TipoRenglon { get; set; }
        [Column("num_cuenta", TypeName = "decimal(4, 0)")]
        public decimal NumCuenta { get; set; }
        [Column("sub_cuenta", TypeName = "decimal(4, 0)")]
        public decimal SubCuenta { get; set; }
        [Column("sub_subcuenta", TypeName = "decimal(4, 0)")]
        public decimal SubSubcuenta { get; set; }
        [Column("porcentaje_aplicar", TypeName = "decimal(3, 0)")]
        public decimal PorcentajeAplicar { get; set; }
    }
}
