using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_detalle_imp_comple")]
    [Index(nameof(Rowguid), Name = "index_603201249", IsUnique = true)]
    public partial class FpedDetalleImpComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Column("cantidad_tarifa_ec", TypeName = "numeric(15, 3)")]
        public decimal CantidadTarifaEc { get; set; }
        [Required]
        [Column("cve_unidad_tarifa_ec")]
        [StringLength(3)]
        public string CveUnidadTarifaEc { get; set; }
        [Column("arancel_ec", TypeName = "numeric(12, 0)")]
        public decimal? ArancelEc { get; set; }
        [Column("tasa_ec", TypeName = "numeric(10, 5)")]
        public decimal? TasaEc { get; set; }
        [Column("id_fraccion_ec")]
        [StringLength(10)]
        public string IdFraccionEc { get; set; }
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
