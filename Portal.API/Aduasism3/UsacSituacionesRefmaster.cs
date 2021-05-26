using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("usac_situaciones_refmaster")]
    public partial class UsacSituacionesRefmaster
    {
        [Key]
        [Column("id_situacion")]
        [StringLength(1)]
        public string IdSituacion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(60)]
        public string Descripcion { get; set; }
    }
}
