using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frestriccion")]
    [Index(nameof(Rowguid), Name = "index_1842105603", IsUnique = true)]
    public partial class Frestriccion
    {
        [Key]
        [Column("id_procedimiento")]
        [StringLength(10)]
        public string IdProcedimiento { get; set; }
        [Key]
        [Column("id_clase")]
        [StringLength(10)]
        public string IdClase { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
