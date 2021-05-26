using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("no_personal")]
    public partial class NoPersonal
    {
        [Key]
        [Column("num_empleado", TypeName = "numeric(9, 0)")]
        public decimal NumEmpleado { get; set; }
        [Column("folio_solicitud", TypeName = "numeric(9, 0)")]
        public decimal FolioSolicitud { get; set; }
        [Column("nombre_empl")]
        [StringLength(60)]
        public string NombreEmpl { get; set; }
        [Column("apellido_paterno")]
        [StringLength(20)]
        public string ApellidoPaterno { get; set; }
        [Column("apellido_materno")]
        [StringLength(20)]
        public string ApellidoMaterno { get; set; }
        [Column("nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Column("num_ss")]
        [StringLength(12)]
        public string NumSs { get; set; }
        [Column("rfc")]
        [StringLength(14)]
        public string Rfc { get; set; }
        [Column("cve_categoria")]
        [StringLength(20)]
        public string CveCategoria { get; set; }
        [Column("cve_sindicato", TypeName = "numeric(2, 0)")]
        public decimal? CveSindicato { get; set; }
        [Column("motivos")]
        [StringLength(50)]
        public string Motivos { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("fecha_baja", TypeName = "datetime")]
        public DateTime? FechaBaja { get; set; }
        [Column("status", TypeName = "numeric(1, 0)")]
        public decimal? Status { get; set; }
        [Column("tipo_nomina", TypeName = "numeric(3, 0)")]
        public decimal? TipoNomina { get; set; }
        [Column("sexo")]
        [StringLength(1)]
        public string Sexo { get; set; }
        [Column("direccion")]
        [StringLength(255)]
        public string Direccion { get; set; }
        [Column("colonia")]
        [StringLength(40)]
        public string Colonia { get; set; }
        [Column("ciudad")]
        [StringLength(40)]
        public string Ciudad { get; set; }
        [Column("tipo_personal")]
        [StringLength(15)]
        public string TipoPersonal { get; set; }
        [Column("edo_civil", TypeName = "numeric(1, 0)")]
        public decimal? EdoCivil { get; set; }
        [Column("codigo_postal", TypeName = "numeric(6, 0)")]
        public decimal? CodigoPostal { get; set; }
        [Column("delegacion")]
        [StringLength(50)]
        public string Delegacion { get; set; }
        [Column("estado")]
        [StringLength(50)]
        public string Estado { get; set; }
        [Column("telefono1")]
        [StringLength(16)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(16)]
        public string Telefono2 { get; set; }
        [Column("pais")]
        [StringLength(50)]
        public string Pais { get; set; }
        [Column("fecha_alta", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("num_contrato")]
        [StringLength(20)]
        public string NumContrato { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("fecha_nacimiento", TypeName = "datetime")]
        public DateTime? FechaNacimiento { get; set; }
        [Column("num_bancono", TypeName = "numeric(3, 0)")]
        public decimal? NumBancono { get; set; }
        [Column("cta_bancono")]
        [StringLength(50)]
        public string CtaBancono { get; set; }
        [Column("num_bancosar", TypeName = "numeric(3, 0)")]
        public decimal? NumBancosar { get; set; }
        [Column("cta_bancosar")]
        [StringLength(50)]
        public string CtaBancosar { get; set; }
        [Column("num_credinfonavit", TypeName = "numeric(10, 0)")]
        public decimal? NumCredinfonavit { get; set; }
        [Column("fecha_inidctoinfonavit", TypeName = "datetime")]
        public DateTime? FechaInidctoinfonavit { get; set; }
        [Column("tipo_dctoinfonavit", TypeName = "numeric(1, 0)")]
        public decimal? TipoDctoinfonavit { get; set; }
        [Column("valor_dctoinfonavit", TypeName = "decimal(4, 4)")]
        public decimal? ValorDctoinfonavit { get; set; }
        [Column("tipo_jornada", TypeName = "numeric(1, 0)")]
        public decimal? TipoJornada { get; set; }
        [Column("sdi_anterior", TypeName = "decimal(12, 4)")]
        public decimal? SdiAnterior { get; set; }
        [Column("sdi_actual", TypeName = "decimal(12, 4)")]
        public decimal? SdiActual { get; set; }
        [Column("cve_ubicacion")]
        [StringLength(17)]
        public string CveUbicacion { get; set; }
        [Column("ispt_retenido", TypeName = "decimal(14, 4)")]
        public decimal? IsptRetenido { get; set; }
        [Column("cas_retenido", TypeName = "decimal(14, 4)")]
        public decimal? CasRetenido { get; set; }
        [Column("ultimo_pagono", TypeName = "decimal(14, 4)")]
        public decimal? UltimoPagono { get; set; }
        [Column("ultimo_pagosar", TypeName = "decimal(14, 4)")]
        public decimal? UltimoPagosar { get; set; }
        [Column("fecha_pagono", TypeName = "datetime")]
        public DateTime? FechaPagono { get; set; }
        [Column("fecha_pagosar", TypeName = "datetime")]
        public DateTime? FechaPagosar { get; set; }
        [Column("tipo_empleado", TypeName = "numeric(1, 0)")]
        public decimal? TipoEmpleado { get; set; }
        [Column("retenido_ajuste", TypeName = "decimal(14, 4)")]
        public decimal? RetenidoAjuste { get; set; }
        [Column("tipo_salario")]
        [StringLength(1)]
        public string TipoSalario { get; set; }
    }
}
