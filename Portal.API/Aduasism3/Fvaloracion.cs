using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fvaloracion")]
    [Index(nameof(Rowguid), Name = "index_1154103152", IsUnique = true)]
    public partial class Fvaloracion
    {
        [Key]
        [Column("id_valoracion")]
        [StringLength(1)]
        public string IdValoracion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
