using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_concepto_contable")]
    public partial class CoConceptoContable
    {
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("cve_area", TypeName = "decimal(3, 0)")]
        public decimal CveArea { get; set; }
        [Required]
        [Column("centro_costos")]
        [StringLength(8)]
        public string CentroCostos { get; set; }
        [Required]
        [Column("sub_centro_costos")]
        [StringLength(8)]
        public string SubCentroCostos { get; set; }
    }
}
