using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_serie_catalogo")]
    [Index(nameof(Marca), nameof(Modelo), nameof(NumeroSerie), Name = "oc_serie_catalogo_UQ", IsUnique = true)]
    public partial class OcSerieCatalogo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("marca")]
        [StringLength(40)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(40)]
        public string Modelo { get; set; }
        [Required]
        [Column("numero_serie")]
        [StringLength(40)]
        public string NumeroSerie { get; set; }
    }
}
