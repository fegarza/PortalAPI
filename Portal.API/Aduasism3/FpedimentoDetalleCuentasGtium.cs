using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_detalle_cuentas_gtia")]
    [Index(nameof(Rowguid), Name = "index_221295898", IsUnique = true)]
    public partial class FpedimentoDetalleCuentasGtium
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
        [Column("advalorem_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? AdvaloremPorcentaje { get; set; }
        [Column("advalorem_forma_pago1")]
        [StringLength(2)]
        public string AdvaloremFormaPago1 { get; set; }
        [Column("advalorem_importe1", TypeName = "decimal(12, 0)")]
        public decimal? AdvaloremImporte1 { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("iva_forma_pago1")]
        [StringLength(2)]
        public string IvaFormaPago1 { get; set; }
        [Column("iva_importe1", TypeName = "decimal(12, 0)")]
        public decimal? IvaImporte1 { get; set; }
        [Column("cuota_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? CuotaPorcentaje { get; set; }
        [Column("cuota_forma_pago1")]
        [StringLength(2)]
        public string CuotaFormaPago1 { get; set; }
        [Column("cuota_importe1", TypeName = "decimal(12, 0)")]
        public decimal? CuotaImporte1 { get; set; }
        [Column("isan_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IsanPorcentaje { get; set; }
        [Column("isan_forma_pago1")]
        [StringLength(2)]
        public string IsanFormaPago1 { get; set; }
        [Column("isan_importe1", TypeName = "decimal(12, 0)")]
        public decimal? IsanImporte1 { get; set; }
        [Column("ieps_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IepsPorcentaje { get; set; }
        [Column("ieps_forma_pago1")]
        [StringLength(2)]
        public string IepsFormaPago1 { get; set; }
        [Column("ieps_importe1", TypeName = "decimal(12, 0)")]
        public decimal? IepsImporte1 { get; set; }
        [Column("dta_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? DtaPorcentaje { get; set; }
        [Column("dta_forma_pago1")]
        [StringLength(2)]
        public string DtaFormaPago1 { get; set; }
        [Column("dta_importe1", TypeName = "decimal(12, 0)")]
        public decimal? DtaImporte1 { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
