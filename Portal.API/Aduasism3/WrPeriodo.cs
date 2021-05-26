using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_periodo")]
    public partial class WrPeriodo
    {
        [Key]
        [Column("id_periodo")]
        public int IdPeriodo { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
    }
}
