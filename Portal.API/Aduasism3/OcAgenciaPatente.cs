using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_agencia_patente")]
    public partial class OcAgenciaPatente
    {
        [Key]
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
    }
}
