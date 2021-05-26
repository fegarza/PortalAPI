using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_mercancia")]
    public partial class FtipoMercancium
    {
        [Key]
        [Column("tipo_mercancia")]
        [StringLength(2)]
        public string TipoMercancia { get; set; }
        [Required]
        [Column("descripción")]
        [StringLength(100)]
        public string Descripción { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
