using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_flete")]
    [Index(nameof(Rowguid), Name = "index_747201762", IsUnique = true)]
    public partial class FtipoFlete
    {
        [Key]
        [Column("id_tipo_flete")]
        [StringLength(1)]
        public string IdTipoFlete { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(70)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
