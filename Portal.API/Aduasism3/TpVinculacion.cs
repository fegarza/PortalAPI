using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_vinculacion")]
    public partial class TpVinculacion
    {
        [Key]
        [Column("id_vinculacion")]
        [StringLength(1)]
        public string IdVinculacion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
