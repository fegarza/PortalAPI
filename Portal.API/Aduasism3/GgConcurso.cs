using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_concursos")]
    public partial class GgConcurso
    {
        [Key]
        [Column("cve_concurso")]
        [StringLength(10)]
        public string CveConcurso { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
