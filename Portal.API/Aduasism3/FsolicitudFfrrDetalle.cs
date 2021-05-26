using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsolicitud_ffrr_detalle")]
    [Index(nameof(Rowguid), Name = "index_1890105774", IsUnique = true)]
    public partial class FsolicitudFfrrDetalle
    {
        [Key]
        [Column("id_solicitud")]
        [StringLength(10)]
        public string IdSolicitud { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("bultos", TypeName = "numeric(8, 0)")]
        public decimal Bultos { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
