using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_obser_comple")]
    [Index(nameof(Rowguid), Name = "index_315200223", IsUnique = true)]
    public partial class FpedObserComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Column("observaciones")]
        [StringLength(120)]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
