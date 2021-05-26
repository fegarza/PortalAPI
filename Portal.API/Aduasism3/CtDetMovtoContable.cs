using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_det_movto_contable")]
    [Index(nameof(CvePeriodo), nameof(CvePoliza), nameof(NumeroMovto), nameof(DebitoCredito), Name = "Indx_ct_det_movto_contable_cve_periodo_cve_poliza_numero_movto_debito_credito")]
    public partial class CtDetMovtoContable
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("cve_periodo", TypeName = "decimal(6, 0)")]
        public decimal CvePeriodo { get; set; }
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Key]
        [Column("numero_movto", TypeName = "decimal(6, 0)")]
        public decimal NumeroMovto { get; set; }
        [Key]
        [Column("consec_aplicacion", TypeName = "decimal(6, 0)")]
        public decimal ConsecAplicacion { get; set; }
        [Required]
        [Column("tipo_poliza")]
        [StringLength(1)]
        public string TipoPoliza { get; set; }
        [Column("consec_poliza", TypeName = "decimal(6, 0)")]
        public decimal ConsecPoliza { get; set; }
        [Required]
        [Column("debito_credito")]
        [StringLength(1)]
        public string DebitoCredito { get; set; }
        [Column("num_cuenta", TypeName = "decimal(4, 0)")]
        public decimal NumCuenta { get; set; }
        [Column("sub_cuenta", TypeName = "decimal(4, 0)")]
        public decimal SubCuenta { get; set; }
        [Column("sub_subcuenta", TypeName = "decimal(4, 0)")]
        public decimal SubSubcuenta { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("importe_movto", TypeName = "decimal(16, 2)")]
        public decimal? ImporteMovto { get; set; }
        [Column("num_beneficiario", TypeName = "decimal(6, 0)")]
        public decimal? NumBeneficiario { get; set; }
        [Column("referencia")]
        [StringLength(100)]
        public string Referencia { get; set; }
        [Column("dia_movto", TypeName = "decimal(2, 0)")]
        public decimal? DiaMovto { get; set; }
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal? TipoBeneficiario { get; set; }
        [Column("referencia_origen")]
        [StringLength(255)]
        public string ReferenciaOrigen { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal? NumDocumento { get; set; }
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal? NumDoctoPago { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
    }
}
