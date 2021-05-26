using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tipo_lineafletera")]
    public partial class OcTipoLineafletera
    {
        [Key]
        [Column("cve_tipo_linea")]
        [StringLength(1)]
        public string CveTipoLinea { get; set; }
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
    }
}
