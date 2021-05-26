using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_diferencias")]
    [Index(nameof(Rowguid), Name = "index_59863280", IsUnique = true)]
    public partial class FpedimentoDiferencia
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("dta_fp1")]
        [StringLength(2)]
        public string DtaFp1 { get; set; }
        [Column("dta_fp2")]
        [StringLength(2)]
        public string DtaFp2 { get; set; }
        [Column("dta_importe1", TypeName = "numeric(12, 0)")]
        public decimal? DtaImporte1 { get; set; }
        [Column("dta_importe2", TypeName = "numeric(12, 0)")]
        public decimal? DtaImporte2 { get; set; }
        [Column("recargo_forma_pago")]
        [StringLength(2)]
        public string RecargoFormaPago { get; set; }
        [Column("recargo_importe", TypeName = "numeric(12, 0)")]
        public decimal? RecargoImporte { get; set; }
        [Column("importe_efectivo", TypeName = "numeric(12, 0)")]
        public decimal? ImporteEfectivo { get; set; }
        [Column("importe_otros", TypeName = "numeric(12, 0)")]
        public decimal? ImporteOtros { get; set; }
        [Column("iva_forma_pago1")]
        [StringLength(2)]
        public string IvaFormaPago1 { get; set; }
        [Column("iva_forma_pago2")]
        [StringLength(2)]
        public string IvaFormaPago2 { get; set; }
        [Column("iva_importe1", TypeName = "numeric(12, 0)")]
        public decimal? IvaImporte1 { get; set; }
        [Column("iva_importe2", TypeName = "numeric(12, 0)")]
        public decimal? IvaImporte2 { get; set; }
        [Column("advalorem_forma_pago1")]
        [StringLength(2)]
        public string AdvaloremFormaPago1 { get; set; }
        [Column("advalorem_forma_pago2")]
        [StringLength(2)]
        public string AdvaloremFormaPago2 { get; set; }
        [Column("advalorem_importe1", TypeName = "numeric(12, 0)")]
        public decimal? AdvaloremImporte1 { get; set; }
        [Column("advalorem_importe2", TypeName = "numeric(12, 0)")]
        public decimal? AdvaloremImporte2 { get; set; }
        [Column("isan_forma_pago")]
        [StringLength(2)]
        public string IsanFormaPago { get; set; }
        [Column("isan_importe", TypeName = "numeric(12, 0)")]
        public decimal? IsanImporte { get; set; }
        [Column("ieps_forma_pago")]
        [StringLength(2)]
        public string IepsFormaPago { get; set; }
        [Column("ieps_importe", TypeName = "numeric(12, 0)")]
        public decimal? IepsImporte { get; set; }
        [Column("cuota_comp_forma_pago1")]
        [StringLength(2)]
        public string CuotaCompFormaPago1 { get; set; }
        [Column("cuota_comp_forma_pago2")]
        [StringLength(2)]
        public string CuotaCompFormaPago2 { get; set; }
        [Column("cuota_comp_importe1", TypeName = "numeric(12, 0)")]
        public decimal? CuotaCompImporte1 { get; set; }
        [Column("cuota_comp_importe2", TypeName = "numeric(12, 0)")]
        public decimal? CuotaCompImporte2 { get; set; }
        [Column("recargo_equivalente", TypeName = "numeric(12, 0)")]
        public decimal? RecargoEquivalente { get; set; }
        [Column("recargo_equivalente_fp")]
        [StringLength(2)]
        public string RecargoEquivalenteFp { get; set; }
        [Column("art_303_forma_pago")]
        [StringLength(2)]
        public string Art303FormaPago { get; set; }
        [Column("art_303_importe_mn", TypeName = "numeric(12, 0)")]
        public decimal? Art303ImporteMn { get; set; }
        [Column("prevalidacion_importe", TypeName = "decimal(12, 0)")]
        public decimal? PrevalidacionImporte { get; set; }
        [Column("prevalidacion_forma_pago")]
        [StringLength(2)]
        public string PrevalidacionFormaPago { get; set; }
        [Column("multa_importe", TypeName = "decimal(12, 0)")]
        public decimal? MultaImporte { get; set; }
        [Column("multa_fp")]
        [StringLength(2)]
        public string MultaFp { get; set; }
        [Column("certificado_importe", TypeName = "decimal(12, 0)")]
        public decimal? CertificadoImporte { get; set; }
        [Column("certificado_fp")]
        [StringLength(2)]
        public string CertificadoFp { get; set; }
        [Column("adv_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? AdvCtagtiaImporte { get; set; }
        [Column("adv_ctagtia_fp")]
        [StringLength(2)]
        public string AdvCtagtiaFp { get; set; }
        [Column("iva_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? IvaCtagtiaImporte { get; set; }
        [Column("iva_ctagtia_fp")]
        [StringLength(2)]
        public string IvaCtagtiaFp { get; set; }
        [Column("cuo_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? CuoCtagtiaImporte { get; set; }
        [Column("cuo_ctagtia_fp")]
        [StringLength(2)]
        public string CuoCtagtiaFp { get; set; }
        [Column("isa_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? IsaCtagtiaImporte { get; set; }
        [Column("isa_ctagtia_fp")]
        [StringLength(2)]
        public string IsaCtagtiaFp { get; set; }
        [Column("iep_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? IepCtagtiaImporte { get; set; }
        [Column("iep_ctagtia_fp")]
        [StringLength(2)]
        public string IepCtagtiaFp { get; set; }
        [Column("itv_importe", TypeName = "decimal(12, 0)")]
        public decimal? ItvImporte { get; set; }
        [Column("itv_fp")]
        [StringLength(2)]
        public string ItvFp { get; set; }
        [Column("dta_ctagtia_importe", TypeName = "decimal(12, 0)")]
        public decimal? DtaCtagtiaImporte { get; set; }
        [Column("dta_ctagtia_fp")]
        [StringLength(2)]
        public string DtaCtagtiaFp { get; set; }
        [Column("importe_fv", TypeName = "decimal(12, 0)")]
        public decimal? ImporteFv { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("mt_forma_pago")]
        [StringLength(2)]
        public string MtFormaPago { get; set; }
        [Column("mt_importe", TypeName = "numeric(12, 0)")]
        public decimal? MtImporte { get; set; }
        [Column("contrapres_importe", TypeName = "decimal(12, 0)")]
        public decimal ContrapresImporte { get; set; }
        [Column("recargo_forma_pago2")]
        [StringLength(2)]
        public string RecargoFormaPago2 { get; set; }
        [Column("recargo_importe2", TypeName = "decimal(12, 0)")]
        public decimal? RecargoImporte2 { get; set; }
    }
}
