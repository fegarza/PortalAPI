using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_det_recibo_ingreso_ad")]
    public partial class TeDetReciboIngresoAd
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(10, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Required]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Column("valor_docto_cobro", TypeName = "numeric(16, 4)")]
        public decimal ValorDoctoCobro { get; set; }
        [Key]
        [Column("tipo_beneficiario", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiario { get; set; }
        [Key]
        [Column("cve_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal CveBeneficiario { get; set; }
        [Key]
        [Column("cve_cpto_ingreso", TypeName = "numeric(3, 0)")]
        public decimal CveCptoIngreso { get; set; }
        [Column("valor_pendiente_amort", TypeName = "numeric(16, 4)")]
        public decimal ValorPendienteAmort { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("consecutivo_cuenta", TypeName = "numeric(9, 5)")]
        public decimal? ConsecutivoCuenta { get; set; }
        [Column("monto_recibido", TypeName = "numeric(16, 4)")]
        public decimal MontoRecibido { get; set; }
        [Column("num_perfil")]
        public byte? NumPerfil { get; set; }
        [Column("c_FormaPago")]
        [StringLength(3)]
        public string CFormaPago { get; set; }
        [StringLength(13)]
        public string RfcEmisorCtaOrd { get; set; }
        [StringLength(50)]
        public string CtaOrdenante { get; set; }
        [StringLength(300)]
        public string NomBancoOrdExt { get; set; }
        [StringLength(100)]
        public string NumOperacion { get; set; }
    }
}
