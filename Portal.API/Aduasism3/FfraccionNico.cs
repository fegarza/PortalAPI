using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FFRACCION_NICO")]
    public partial class FfraccionNico
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
        [Column("id_nico")]
        [StringLength(2)]
        public string IdNico { get; set; }
        [Column("descripcion")]
        [StringLength(2000)]
        public string Descripcion { get; set; }
        [Column("actualizacion")]
        public int? Actualizacion { get; set; }
        [Column("complemento")]
        [StringLength(10)]
        public string Complemento { get; set; }
        [Column("eliminar")]
        [StringLength(1)]
        public string Eliminar { get; set; }
    }
}
