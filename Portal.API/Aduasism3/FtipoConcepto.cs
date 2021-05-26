using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_concepto")]
    [Index(nameof(Rowguid), Name = "index_578101100", IsUnique = true)]
    public partial class FtipoConcepto
    {
        [Key]
        [Column("id_tipo_concepto")]
        [StringLength(3)]
        public string IdTipoConcepto { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Required]
        [Column("abreviado")]
        [StringLength(5)]
        public string Abreviado { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
