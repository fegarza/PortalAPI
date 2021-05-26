using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_cveinsumo")]
    public partial class CmCveinsumo
    {
        [Key]
        [Column("precedencia", TypeName = "decimal(2, 0)")]
        public decimal Precedencia { get; set; }
        [Key]
        [Column("division")]
        [StringLength(15)]
        public string Division { get; set; }
        [Column("longitud", TypeName = "decimal(2, 0)")]
        public decimal Longitud { get; set; }
        [Required]
        [Column("predefinido")]
        [StringLength(15)]
        public string Predefinido { get; set; }
        [Required]
        [Column("tipo_dato")]
        [StringLength(15)]
        public string TipoDato { get; set; }
        [Column("separador")]
        [StringLength(5)]
        public string Separador { get; set; }
    }
}
