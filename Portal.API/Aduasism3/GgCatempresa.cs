using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_catempresa")]
    public partial class GgCatempresa
    {
        [Key]
        [Column("empresa_responsable", TypeName = "decimal(5, 0)")]
        public decimal EmpresaResponsable { get; set; }
        [Column("nombre")]
        [StringLength(60)]
        public string Nombre { get; set; }
    }
}
