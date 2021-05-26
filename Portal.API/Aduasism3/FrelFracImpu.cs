using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_frac_impu")]
    [Index(nameof(Rowguid), Name = "index_1293963686", IsUnique = true)]
    public partial class FrelFracImpu
    {
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("id_impuesto")]
        [StringLength(2)]
        public string IdImpuesto { get; set; }
        [Column("porc_ieps", TypeName = "decimal(5, 2)")]
        public decimal? PorcIeps { get; set; }
        [Column("cve_gasolina", TypeName = "decimal(1, 0)")]
        public decimal? CveGasolina { get; set; }
        [Column("cuota_valor", TypeName = "decimal(12, 2)")]
        public decimal? CuotaValor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("mt_valor_minimo", TypeName = "numeric(5, 0)")]
        public decimal? MtValorMinimo { get; set; }
    }
}
