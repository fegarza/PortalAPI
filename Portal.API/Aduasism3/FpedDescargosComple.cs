using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_descargos_comple")]
    [Index(nameof(Rowguid), Name = "index_235199938", IsUnique = true)]
    public partial class FpedDescargosComple
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
        [Required]
        [Column("patente_original")]
        [StringLength(4)]
        public string PatenteOriginal { get; set; }
        [Required]
        [Column("pedimento_original")]
        [StringLength(7)]
        public string PedimentoOriginal { get; set; }
        [Column("aduana_original")]
        [StringLength(2)]
        public string AduanaOriginal { get; set; }
        [Column("seccion_original")]
        [StringLength(1)]
        public string SeccionOriginal { get; set; }
        [Column("clave_original")]
        [StringLength(3)]
        public string ClaveOriginal { get; set; }
        [Column("fecha_ope_original", TypeName = "datetime")]
        public DateTime? FechaOpeOriginal { get; set; }
        [Column("fraccion_original")]
        [StringLength(8)]
        public string FraccionOriginal { get; set; }
        [Column("unidad_m_original")]
        [StringLength(2)]
        public string UnidadMOriginal { get; set; }
        [Column("descarga_fraccion", TypeName = "decimal(15, 3)")]
        public decimal? DescargaFraccion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
