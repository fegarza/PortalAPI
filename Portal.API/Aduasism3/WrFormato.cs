using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_formato")]
    public partial class WrFormato
    {
        [Key]
        [Column("id_formato")]
        public int IdFormato { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(30)]
        public string DescripcionEn { get; set; }
        [Required]
        [Column("clave")]
        [StringLength(10)]
        public string Clave { get; set; }
        [Required]
        [Column("tipo")]
        [StringLength(100)]
        public string Tipo { get; set; }
    }
}
