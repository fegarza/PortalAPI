using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcla_calidad")]
    [Index(nameof(Rowguid), Name = "index_1834489614", IsUnique = true)]
    public partial class FclaCalidad
    {
        [Key]
        [Column("id_calidad")]
        [StringLength(2)]
        public string IdCalidad { get; set; }
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("descripcionimp")]
        [StringLength(20)]
        public string Descripcionimp { get; set; }
    }
}
