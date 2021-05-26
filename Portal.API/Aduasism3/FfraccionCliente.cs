using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_cliente")]
    public partial class FfraccionCliente
    {
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
