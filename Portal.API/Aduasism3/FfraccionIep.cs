using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_ieps")]
    public partial class FfraccionIep
    {
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("descripcion", TypeName = "text")]
        public string Descripcion { get; set; }
    }
}
