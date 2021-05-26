using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftlcue_pais")]
    [Index(nameof(Rowguid), Name = "index_1367011951", IsUnique = true)]
    public partial class FtlcuePai
    {
        [Key]
        [Column("id_pais")]
        [StringLength(6)]
        public string IdPais { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(3)]
        public string IdPermiso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
