using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fseccion")]
    [Index(nameof(Rowguid), Name = "index_1127675065", IsUnique = true)]
    public partial class Fseccion
    {
        [Key]
        [Column("seccion")]
        [StringLength(15)]
        public string Seccion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
