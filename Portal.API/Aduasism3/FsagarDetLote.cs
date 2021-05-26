using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsagar_det_lote")]
    [Index(nameof(Rowguid), Name = "index_1867205752", IsUnique = true)]
    public partial class FsagarDetLote
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "decimal(4, 0)")]
        public decimal Secuencial { get; set; }
        [Key]
        [Column("consec_lote", TypeName = "decimal(3, 0)")]
        public decimal ConsecLote { get; set; }
        [Required]
        [Column("lote")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("id_calidad")]
        [StringLength(2)]
        public string IdCalidad { get; set; }
        [Column("fecha_embalaje", TypeName = "datetime")]
        public DateTime? FechaEmbalaje { get; set; }
        [Column("fecha_sacrificio", TypeName = "datetime")]
        public DateTime? FechaSacrificio { get; set; }
        [Column("fecha_caducidad", TypeName = "datetime")]
        public DateTime? FechaCaducidad { get; set; }
        [Column("fecha_elaboracion", TypeName = "datetime")]
        public DateTime? FechaElaboracion { get; set; }
        [Column("fecha_embalaje_final", TypeName = "datetime")]
        public DateTime? FechaEmbalajeFinal { get; set; }
        [Column("fecha_sacrificio_final", TypeName = "datetime")]
        public DateTime? FechaSacrificioFinal { get; set; }
        [Column("fecha_caducidad_final", TypeName = "datetime")]
        public DateTime? FechaCaducidadFinal { get; set; }
        [Column("fecha_elaboracion_final", TypeName = "datetime")]
        public DateTime? FechaElaboracionFinal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("lote2")]
        [StringLength(40)]
        public string Lote2 { get; set; }
    }
}
