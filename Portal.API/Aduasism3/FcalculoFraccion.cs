using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcalculo_fraccion")]
    [Index(nameof(Rowguid), Name = "index_708197573", IsUnique = true)]
    public partial class FcalculoFraccion
    {
        [Key]
        [Column("id_calculo")]
        [StringLength(6)]
        public string IdCalculo { get; set; }
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Key]
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(4, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Column("importe", TypeName = "numeric(12, 2)")]
        public decimal? Importe { get; set; }
        [Column("valor_aduana_frac", TypeName = "numeric(12, 2)")]
        public decimal? ValorAduanaFrac { get; set; }
        [Column("dta_frac", TypeName = "numeric(12, 0)")]
        public decimal? DtaFrac { get; set; }
        [Column("adval_porc", TypeName = "numeric(5, 2)")]
        public decimal? AdvalPorc { get; set; }
        [Column("adval_pref", TypeName = "numeric(5, 2)")]
        public decimal? AdvalPref { get; set; }
        [Column("adval_monto", TypeName = "numeric(12, 0)")]
        public decimal? AdvalMonto { get; set; }
        [Column("ieps_porc", TypeName = "numeric(5, 2)")]
        public decimal? IepsPorc { get; set; }
        [Column("ieps_gaso", TypeName = "numeric(1, 0)")]
        public decimal? IepsGaso { get; set; }
        [Column("ieps_mn", TypeName = "numeric(12, 0)")]
        public decimal? IepsMn { get; set; }
        [Column("iva_porc", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorc { get; set; }
        [Column("iva_mn", TypeName = "numeric(12, 0)")]
        public decimal? IvaMn { get; set; }
        [Column("cuota_porc", TypeName = "numeric(5, 2)")]
        public decimal? CuotaPorc { get; set; }
        [Column("cuota_monto", TypeName = "numeric(12, 2)")]
        public decimal? CuotaMonto { get; set; }
        [Column("cuota_mn", TypeName = "numeric(12, 0)")]
        public decimal? CuotaMn { get; set; }
        [Column("isan_porc", TypeName = "numeric(5, 2)")]
        public decimal? IsanPorc { get; set; }
        [Column("isan_monto", TypeName = "numeric(12, 0)")]
        public decimal? IsanMonto { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey("CveTipoOpn,IdFraccionMex")]
        [InverseProperty("FcalculoFraccions")]
        public virtual FfraccionMex FfraccionMex { get; set; }
        [ForeignKey(nameof(IdCalculo))]
        [InverseProperty(nameof(FcalculoGeneral.FcalculoFraccions))]
        public virtual FcalculoGeneral IdCalculoNavigation { get; set; }
        [ForeignKey(nameof(IdTipoAdvalorem))]
        [InverseProperty(nameof(FtipoAdvalorem.FcalculoFraccions))]
        public virtual FtipoAdvalorem IdTipoAdvaloremNavigation { get; set; }
    }
}
