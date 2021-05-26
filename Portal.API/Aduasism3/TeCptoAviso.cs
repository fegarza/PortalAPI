using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("te_cpto_aviso")]
    public partial class TeCptoAviso
    {
        [Column("cve_cpto_aviso", TypeName = "numeric(3, 0)")]
        public decimal CveCptoAviso { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("tipo_aviso", TypeName = "numeric(1, 0)")]
        public decimal? TipoAviso { get; set; }
    }
}
