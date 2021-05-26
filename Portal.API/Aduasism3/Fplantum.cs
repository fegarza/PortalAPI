using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fplanta")]
    public partial class Fplantum
    {
        [Key]
        [Column("planta")]
        [StringLength(6)]
        public string Planta { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("prefijo_planta")]
        [StringLength(6)]
        public string PrefijoPlanta { get; set; }
    }
}
