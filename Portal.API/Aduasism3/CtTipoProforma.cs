using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_tipo_proforma")]
    public partial class CtTipoProforma
    {
        [Key]
        [Column("tipo_proforma", TypeName = "decimal(3, 0)")]
        public decimal TipoProforma { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(60)]
        public string Descripcion { get; set; }
    }
}
