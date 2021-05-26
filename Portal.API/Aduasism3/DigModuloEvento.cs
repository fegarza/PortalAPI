using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_modulo_evento")]
    public partial class DigModuloEvento
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_evento")]
        [StringLength(20)]
        public string IdEvento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
    }
}
