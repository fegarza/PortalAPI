using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_informes_contables")]
    public partial class CtInformesContable
    {
        [Key]
        [Column("cve_informe", TypeName = "decimal(3, 0)")]
        public decimal CveInforme { get; set; }
        [Required]
        [Column("descr_informe_contab")]
        [StringLength(60)]
        public string DescrInformeContab { get; set; }
    }
}
