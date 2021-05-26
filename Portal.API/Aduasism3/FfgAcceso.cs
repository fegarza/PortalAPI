using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_accesos")]
    public partial class FfgAcceso
    {
        [Required]
        [Column("id_clase")]
        [StringLength(10)]
        public string IdClase { get; set; }
        [Required]
        [Column("id_proceso")]
        [StringLength(2)]
        public string IdProceso { get; set; }
        [Required]
        [Column("id_objeto")]
        [StringLength(10)]
        public string IdObjeto { get; set; }
        [Column("ingresar", TypeName = "numeric(1, 0)")]
        public decimal? Ingresar { get; set; }
        [Column("modificar", TypeName = "numeric(1, 0)")]
        public decimal? Modificar { get; set; }
        [Column("eliminar", TypeName = "numeric(1, 0)")]
        public decimal? Eliminar { get; set; }
        [Column("imprimir", TypeName = "numeric(1, 0)")]
        public decimal? Imprimir { get; set; }
    }
}
