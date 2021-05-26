using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_consec_poliza")]
    public partial class CtConsecPoliza
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Column("consec_poliza", TypeName = "decimal(6, 0)")]
        public decimal ConsecPoliza { get; set; }
    }
}
