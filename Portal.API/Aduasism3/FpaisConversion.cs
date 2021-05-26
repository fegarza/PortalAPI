using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpais_conversion")]
    public partial class FpaisConversion
    {
        [Key]
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
        [Required]
        [Column("id_pais_com")]
        [StringLength(5)]
        public string IdPaisCom { get; set; }
    }
}
