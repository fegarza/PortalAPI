using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_regimen_compliance")]
    public partial class FrelRegimenCompliance
    {
        [Key]
        [Column("tipo_Regimen")]
        [StringLength(2)]
        public string TipoRegimen { get; set; }
        [Key]
        [Column("id_Regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("id_compliance")]
        [StringLength(3)]
        public string IdCompliance { get; set; }
    }
}
