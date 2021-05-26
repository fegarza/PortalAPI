using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("flaboratorio")]
    [Index(nameof(Rowguid), Name = "index_1764253390", IsUnique = true)]
    public partial class Flaboratorio
    {
        [Key]
        [Column("clave_lab")]
        [StringLength(2)]
        public string ClaveLab { get; set; }
        [Column("descripcion")]
        [StringLength(80)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
