using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_parametros_estructura")]
    public partial class PrParametrosEstructura
    {
        [Key]
        [Column("cve_nivel")]
        public int CveNivel { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Required]
        [Column("abreviacion")]
        [StringLength(10)]
        public string Abreviacion { get; set; }
        [Column("tamaño")]
        public int Tamaño { get; set; }
        [Column("incremento")]
        public int Incremento { get; set; }
        [Column("cptos_identicos")]
        public int? CptosIdenticos { get; set; }
    }
}
