using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frecargo")]
    [Index(nameof(Rowguid), Name = "index_130099504", IsUnique = true)]
    public partial class Frecargo
    {
        [Key]
        [Column("id_anio")]
        [StringLength(4)]
        public string IdAnio { get; set; }
        [Key]
        [Column("id_mes")]
        [StringLength(2)]
        public string IdMes { get; set; }
        [Column("recargo", TypeName = "numeric(7, 4)")]
        public decimal Recargo { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
