using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcatalogo_opn")]
    public partial class FcatalogoOpn
    {
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(4)]
        public string CveTipoOpn { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("tipo_opn")]
        [StringLength(2)]
        public string TipoOpn { get; set; }
        [Column("tipo_opn_ie")]
        [StringLength(2)]
        public string TipoOpnIe { get; set; }
    }
}
