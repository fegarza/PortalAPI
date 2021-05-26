using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_dia_semana")]
    public partial class WrDiaSemana
    {
        [Key]
        [Column("dia")]
        public short Dia { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(20)]
        public string DescripcionEn { get; set; }
        [Required]
        [Column("clave")]
        [StringLength(3)]
        public string Clave { get; set; }
    }
}
