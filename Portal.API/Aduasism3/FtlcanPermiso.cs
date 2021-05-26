using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftlcan_permiso")]
    [Index(nameof(Rowguid), Name = "index_1453964256", IsUnique = true)]
    public partial class FtlcanPermiso
    {
        [Key]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Key]
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
