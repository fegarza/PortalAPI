using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fembarque_eliminado")]
    public partial class FembarqueEliminado
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Key]
        [Column("fecha_eliminado", TypeName = "datetime")]
        public DateTime FechaEliminado { get; set; }
    }
}
