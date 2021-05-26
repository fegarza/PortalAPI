using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_valoracion")]
    public partial class TpValoracion
    {
        [Key]
        [Column("id_valoracion")]
        [StringLength(1)]
        public string IdValoracion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
