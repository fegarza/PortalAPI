using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_jefecompras")]
    public partial class CmJefecompra
    {
        [Key]
        [Column("no_tarea")]
        public int NoTarea { get; set; }
        [Required]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("cveautorizacion")]
        [StringLength(20)]
        public string Cveautorizacion { get; set; }
        [Required]
        [Column("password")]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column("monto_min", TypeName = "decimal(14, 4)")]
        public decimal MontoMin { get; set; }
        [Column("monto_max", TypeName = "decimal(14, 4)")]
        public decimal MontoMax { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Required]
        [Column("login")]
        [StringLength(8)]
        public string Login { get; set; }
    }
}
