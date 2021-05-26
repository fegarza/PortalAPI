using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_tipo_conversion")]
    public partial class CtTipoConversion
    {
        [Key]
        [Column("cve_tabla", TypeName = "decimal(4, 0)")]
        public decimal CveTabla { get; set; }
        [Column("tipo_dato_origen", TypeName = "decimal(1, 0)")]
        public decimal TipoDatoOrigen { get; set; }
        [Required]
        [Column("descri_tabla")]
        [StringLength(60)]
        public string DescriTabla { get; set; }
        [Column("long_dato_origen", TypeName = "decimal(2, 0)")]
        public decimal LongDatoOrigen { get; set; }
    }
}
