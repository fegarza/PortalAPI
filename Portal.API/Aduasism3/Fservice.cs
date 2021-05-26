using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fservice")]
    [Index(nameof(Rowguid), Name = "index_386100416", IsUnique = true)]
    public partial class Fservice
    {
        [Key]
        [Column("id_service")]
        [StringLength(3)]
        public string IdService { get; set; }
        [Column("nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
