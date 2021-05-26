using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frelacion_ffrr_detalle")]
    [Index(nameof(Rowguid), Name = "index_1631344876", IsUnique = true)]
    public partial class FrelacionFfrrDetalle
    {
        [Key]
        [Column("id_relacion")]
        [StringLength(10)]
        public string IdRelacion { get; set; }
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
