using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_det_cuenta_aduanera")]
    [Index(nameof(Rowguid), Name = "index_1492916390", IsUnique = true)]
    public partial class FpedimentoDetCuentaAduanera
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
        [Column("inst_emisora")]
        [StringLength(2)]
        public string InstEmisora { get; set; }
        [Column("numero_cuenta")]
        [StringLength(17)]
        public string NumeroCuenta { get; set; }
        [Column("folio_cuenta")]
        [StringLength(17)]
        public string FolioCuenta { get; set; }
        [Column("fecha_constancia", TypeName = "datetime")]
        public DateTime? FechaConstancia { get; set; }
        [Column("cve_garantia")]
        [StringLength(1)]
        public string CveGarantia { get; set; }
        [Column("valor_unitario", TypeName = "numeric(19, 4)")]
        public decimal? ValorUnitario { get; set; }
        [Column("total_garantia", TypeName = "money")]
        public decimal? TotalGarantia { get; set; }
        [Column("unidad_precio", TypeName = "decimal(14, 4)")]
        public decimal? UnidadPrecio { get; set; }
        [Column("titulos_asignados", TypeName = "decimal(14, 4)")]
        public decimal? TitulosAsignados { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
