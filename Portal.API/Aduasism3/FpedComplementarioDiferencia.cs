using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_complementario_diferencias")]
    [Index(nameof(Rowguid), Name = "index_219199881", IsUnique = true)]
    public partial class FpedComplementarioDiferencia
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("dta_fp1")]
        [StringLength(2)]
        public string DtaFp1 { get; set; }
        [Column("dta_importe1", TypeName = "decimal(12, 0)")]
        public decimal? DtaImporte1 { get; set; }
        [Column("recargo_forma_pago")]
        [StringLength(2)]
        public string RecargoFormaPago { get; set; }
        [Column("recargo_importe", TypeName = "decimal(12, 0)")]
        public decimal? RecargoImporte { get; set; }
        [Column("importe_efectivo", TypeName = "decimal(12, 0)")]
        public decimal? ImporteEfectivo { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 0)")]
        public decimal? ImporteOtros { get; set; }
        [Column("iva_forma_pago1")]
        [StringLength(2)]
        public string IvaFormaPago1 { get; set; }
        [Column("iva_importe1", TypeName = "decimal(12, 0)")]
        public decimal? IvaImporte1 { get; set; }
        [Column("advalorem_forma_pago1")]
        [StringLength(2)]
        public string AdvaloremFormaPago1 { get; set; }
        [Column("advalorem_importe1", TypeName = "decimal(12, 0)")]
        public decimal? AdvaloremImporte1 { get; set; }
        [Column("i303_forma_pago1")]
        [StringLength(2)]
        public string I303FormaPago1 { get; set; }
        [Column("i303_importe1", TypeName = "decimal(12, 0)")]
        public decimal? I303Importe1 { get; set; }
        [Column("prevalidacion_importe", TypeName = "decimal(12, 0)")]
        public decimal? PrevalidacionImporte { get; set; }
        [Column("prevalidacion_forma_pago")]
        [StringLength(2)]
        public string PrevalidacionFormaPago { get; set; }
        [Column("importe_fv", TypeName = "decimal(12, 0)")]
        public decimal? ImporteFv { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("contrapres_importe", TypeName = "decimal(12, 0)")]
        public decimal? ContrapresImporte { get; set; }
    }
}
