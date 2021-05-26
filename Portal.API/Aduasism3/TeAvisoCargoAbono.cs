using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_aviso_cargo_abono")]
    public partial class TeAvisoCargoAbono
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Key]
        [Column("num_aviso", TypeName = "numeric(10, 0)")]
        public decimal NumAviso { get; set; }
        [Column("tipo_aviso", TypeName = "numeric(1, 0)")]
        public decimal TipoAviso { get; set; }
        [Required]
        [Column("referencia")]
        [StringLength(40)]
        public string Referencia { get; set; }
        [Column("fecha_aviso", TypeName = "datetime")]
        public DateTime FechaAviso { get; set; }
        [Column("cve_cpto_aviso", TypeName = "numeric(3, 0)")]
        public decimal CveCptoAviso { get; set; }
        [Column("importe_total", TypeName = "numeric(16, 4)")]
        public decimal ImporteTotal { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal StatusContable { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(10, 4)")]
        public decimal TipoCambio { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("valor_pesos", TypeName = "numeric(27, 8)")]
        public decimal? ValorPesos { get; set; }
        [Column("comple_dlls", TypeName = "numeric(28, 8)")]
        public decimal? CompleDlls { get; set; }
    }
}
