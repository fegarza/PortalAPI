using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cc_reclasificacion_ingreso")]
    public partial class CcReclasificacionIngreso
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(10, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Key]
        [Column("tipo_beneficiario_ant", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiarioAnt { get; set; }
        [Key]
        [Column("cve_beneficiario_ant", TypeName = "numeric(6, 0)")]
        public decimal CveBeneficiarioAnt { get; set; }
        [Key]
        [Column("cve_cpto_ingreso_ant", TypeName = "numeric(3, 0)")]
        public decimal CveCptoIngresoAnt { get; set; }
        [Column("importe_ant", TypeName = "numeric(16, 4)")]
        public decimal ImporteAnt { get; set; }
        [Column("valor_por_amortizar_ant", TypeName = "numeric(16, 4)")]
        public decimal ValorPorAmortizarAnt { get; set; }
        [Column("tipo_beneficiario_nuevo", TypeName = "numeric(3, 0)")]
        public decimal TipoBeneficiarioNuevo { get; set; }
        [Column("cve_beneficiario_nuevo", TypeName = "numeric(6, 0)")]
        public decimal CveBeneficiarioNuevo { get; set; }
        [Column("cve_cpto_ingreso_nuevo", TypeName = "numeric(3, 0)")]
        public decimal CveCptoIngresoNuevo { get; set; }
        [Column("importe_nuevo", TypeName = "numeric(16, 4)")]
        public decimal ImporteNuevo { get; set; }
        [Column("valor_por_amortizar_nuevo", TypeName = "numeric(16, 4)")]
        public decimal ValorPorAmortizarNuevo { get; set; }
        [Column("fecha_movimiento", TypeName = "datetime")]
        public DateTime FechaMovimiento { get; set; }
        [Column("status_contable", TypeName = "decimal(1, 0)")]
        public decimal StatusContable { get; set; }
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
        [Key]
        [Column("consecutivo_reclasificacion", TypeName = "decimal(8, 0)")]
        public decimal ConsecutivoReclasificacion { get; set; }
    }
}
