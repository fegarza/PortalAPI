using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_descarga")]
    [Index(nameof(Rowguid), Name = "index_321436219", IsUnique = true)]
    public partial class FpedimentoDescarga
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial_descarga", TypeName = "numeric(5, 0)")]
        public decimal SecuencialDescarga { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(17, 5)")]
        public decimal? CantidadComercial { get; set; }
        [Required]
        [Column("cve_unidad_comercial")]
        [StringLength(3)]
        public string CveUnidadComercial { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Column("cve_pedimento_orig")]
        [StringLength(3)]
        public string CvePedimentoOrig { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("partida_pedimento", TypeName = "numeric(5, 0)")]
        public decimal? PartidaPedimento { get; set; }
        [Column("fecha_original", TypeName = "datetime")]
        public DateTime? FechaOriginal { get; set; }
    }
}
