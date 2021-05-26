using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_subnivel_dano")]
    public partial class OcSubnivelDano
    {
        [Key]
        [Column("nivel")]
        public short Nivel { get; set; }
        [Key]
        [Column("subnivel")]
        public short Subnivel { get; set; }
        [Required]
        [Column("descripcionEs")]
        [StringLength(60)]
        public string DescripcionEs { get; set; }
        [Required]
        [Column("descripcionEn")]
        [StringLength(60)]
        public string DescripcionEn { get; set; }
    }
}
