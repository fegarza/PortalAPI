using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_origen_operacion")]
    public partial class CtOrigenOperacion
    {
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Key]
        [Column("numero_detalle", TypeName = "decimal(1, 0)")]
        public decimal NumeroDetalle { get; set; }
        [Key]
        [Column("consec_operacion", TypeName = "decimal(3, 0)")]
        public decimal ConsecOperacion { get; set; }
        [Column("num_dato", TypeName = "decimal(3, 0)")]
        public decimal NumDato { get; set; }
        [Required]
        [Column("operador_1")]
        [StringLength(255)]
        public string Operador1 { get; set; }
        [Required]
        [Column("operador_2")]
        [StringLength(255)]
        public string Operador2 { get; set; }
        [Required]
        [Column("operando")]
        [StringLength(1)]
        public string Operando { get; set; }
    }
}
