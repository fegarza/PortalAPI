using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmedio_transporte")]
    public partial class FmedioTransporte
    {
        [Key]
        [Column("cve_transporte")]
        [StringLength(2)]
        public string CveTransporte { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
