using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fidentificador_no_factor_actualizacion")]
    public partial class FidentificadorNoFactorActualizacion
    {
        [Key]
        [Column("tipo_caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Key]
        [Column("iden_caso")]
        [StringLength(30)]
        public string IdenCaso { get; set; }
    }
}
