using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_consec_tipo_poliza")]
    public partial class CtConsecTipoPoliza
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("tipo_poliza")]
        [StringLength(1)]
        public string TipoPoliza { get; set; }
        [Column("consec_tipo_poliza", TypeName = "decimal(6, 0)")]
        public decimal ConsecTipoPoliza { get; set; }
    }
}
