using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_contratos")]
    public partial class GgContrato
    {
        [Key]
        [Column("cve_contrato")]
        [StringLength(10)]
        public string CveContrato { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
