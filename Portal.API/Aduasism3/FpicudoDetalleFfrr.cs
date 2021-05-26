using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpicudo_detalle_ffrr")]
    [Index(nameof(Rowguid), Name = "index_1647344933", IsUnique = true)]
    public partial class FpicudoDetalleFfrr
    {
        [Key]
        [Column("id_cruce")]
        [StringLength(6)]
        public string IdCruce { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
