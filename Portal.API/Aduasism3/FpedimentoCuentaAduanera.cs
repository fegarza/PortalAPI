using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_cuenta_aduanera")]
    [Index(nameof(Rowguid), Name = "index_1476916333", IsUnique = true)]
    public partial class FpedimentoCuentaAduanera
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
        [Column("inst_emisora")]
        [StringLength(2)]
        public string InstEmisora { get; set; }
        [Column("num_cuenta")]
        [StringLength(17)]
        public string NumCuenta { get; set; }
        [Column("folio_cuenta")]
        [StringLength(17)]
        public string FolioCuenta { get; set; }
        [Column("fecha_constancia", TypeName = "datetime")]
        public DateTime? FechaConstancia { get; set; }
        [Column("cve_cuenta")]
        [StringLength(2)]
        public string CveCuenta { get; set; }
        [Column("cve_garantia")]
        [StringLength(1)]
        public string CveGarantia { get; set; }
        [Column("valor_unitario", TypeName = "money")]
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
