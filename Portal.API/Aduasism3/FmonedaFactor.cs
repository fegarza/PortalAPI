using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmoneda_factor")]
    [Index(nameof(Rowguid), Name = "index_27863166", IsUnique = true)]
    public partial class FmonedaFactor
    {
        [Key]
        [Column("id_anio")]
        [StringLength(4)]
        public string IdAnio { get; set; }
        [Key]
        [Column("id_mes")]
        [StringLength(2)]
        public string IdMes { get; set; }
        [Key]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("factor", TypeName = "numeric(10, 8)")]
        public decimal Factor { get; set; }
        [Column("fecha_dof", TypeName = "datetime")]
        public DateTime? FechaDof { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
