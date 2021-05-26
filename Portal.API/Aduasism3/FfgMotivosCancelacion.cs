using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_motivos_cancelacion")]
    public partial class FfgMotivosCancelacion
    {
        [Key]
        [Column("clave")]
        [StringLength(3)]
        public string Clave { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
