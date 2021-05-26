﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_gasto_comprobar")]
    public partial class CpGastoComprobar
    {
        [Key]
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal NumBeneficiario { get; set; }
        [Key]
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal NumDocumento { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("tipo_cambio", TypeName = "numeric(14, 4)")]
        public decimal? TipoCambio { get; set; }
        [Column("fecha_documento", TypeName = "datetime")]
        public DateTime? FechaDocumento { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        [Column("fecha_contabilizacion", TypeName = "datetime")]
        public DateTime? FechaContabilizacion { get; set; }
        [Column("valor_cxp", TypeName = "numeric(16, 4)")]
        public decimal? ValorCxp { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("num_reembolso", TypeName = "decimal(6, 0)")]
        public decimal NumReembolso { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime? FechaCaptura { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("status_cxp", TypeName = "decimal(1, 0)")]
        public decimal? StatusCxp { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        [Column("forma_pago", TypeName = "numeric(1, 0)")]
        public decimal? FormaPago { get; set; }
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal? NumBanco { get; set; }
        [Column("num_docto_pago", TypeName = "numeric(10, 0)")]
        public decimal? NumDoctoPago { get; set; }
        [Column("saldo_cxp", TypeName = "numeric(16, 4)")]
        public decimal? SaldoCxp { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("tipo_documento", TypeName = "numeric(18, 0)")]
        public decimal? TipoDocumento { get; set; }
        [Column("saldo_comprobar", TypeName = "numeric(16, 4)")]
        public decimal? SaldoComprobar { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Key]
        [Column("tipo_beneficiario")]
        public int TipoBeneficiario { get; set; }
        [Column("referencia")]
        [StringLength(255)]
        public string Referencia { get; set; }
        [Column("num_factura")]
        [StringLength(30)]
        public string NumFactura { get; set; }
    }
}
