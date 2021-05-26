using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fentrada_bodega_respaldo")]
    public partial class FentradaBodegaRespaldo
    {
        [Required]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Required]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        [Required]
        [Column("id_usuario_recibe")]
        [StringLength(6)]
        public string IdUsuarioRecibe { get; set; }
        [Required]
        [Column("marca_mcia")]
        [StringLength(20)]
        public string MarcaMcia { get; set; }
        [Required]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Required]
        [Column("guia_flete")]
        [StringLength(20)]
        public string GuiaFlete { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime FechaGuia { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Column("cve_flete_pagado", TypeName = "numeric(1, 0)")]
        public decimal CveFletePagado { get; set; }
        [Column("importe_flete", TypeName = "numeric(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("poliza_flete")]
        [StringLength(11)]
        public string PolizaFlete { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Required]
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("in_bond")]
        [StringLength(1)]
        public string InBond { get; set; }
        [Column("directa")]
        [StringLength(1)]
        public string Directa { get; set; }
        [Column("seccion_entrada")]
        [StringLength(15)]
        public string SeccionEntrada { get; set; }
        [Column("peso_kgs", TypeName = "numeric(14, 3)")]
        public decimal? PesoKgs { get; set; }
        [Column("peso_libras", TypeName = "numeric(14, 3)")]
        public decimal? PesoLibras { get; set; }
        [Column("servicio_linea")]
        [StringLength(3)]
        public string ServicioLinea { get; set; }
        [Column("dias_libres", TypeName = "numeric(2, 0)")]
        public decimal? DiasLibres { get; set; }
        [Column("importe_demora_dia", TypeName = "numeric(9, 2)")]
        public decimal? ImporteDemoraDia { get; set; }
        [Column("id_ag_ad_ame")]
        [StringLength(6)]
        public string IdAgAdAme { get; set; }
        [Column("inbond_numero")]
        [StringLength(15)]
        public string InbondNumero { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Column("pre_file")]
        [StringLength(20)]
        public string PreFile { get; set; }
        [Column("cve_tipo_transporte")]
        [StringLength(1)]
        public string CveTipoTransporte { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("factor_flete", TypeName = "numeric(10, 8)")]
        public decimal? FactorFlete { get; set; }
        [Column("fecha_inbond", TypeName = "datetime")]
        public DateTime? FechaInbond { get; set; }
        [Column("URGENTE")]
        [StringLength(1)]
        public string Urgente { get; set; }
        [Column("fecha_venc_inbond", TypeName = "datetime")]
        public DateTime? FechaVencInbond { get; set; }
        [Column("control_caja", TypeName = "numeric(6, 0)")]
        public decimal? ControlCaja { get; set; }
        [Column("ref_ups")]
        [StringLength(12)]
        public string RefUps { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("fecha_salida_origen", TypeName = "datetime")]
        public DateTime? FechaSalidaOrigen { get; set; }
        [Column("id_consignatario")]
        [StringLength(10)]
        public string IdConsignatario { get; set; }
        [Column("obs_entrada1")]
        [StringLength(30)]
        public string ObsEntrada1 { get; set; }
        [Column("obs_entrada2")]
        [StringLength(30)]
        public string ObsEntrada2 { get; set; }
        [Column("valor_guia_h", TypeName = "decimal(8, 0)")]
        public decimal? ValorGuiaH { get; set; }
        [Column("id_orden")]
        [StringLength(15)]
        public string IdOrden { get; set; }
        [Column("folio_entrada")]
        [StringLength(10)]
        public string FolioEntrada { get; set; }
    }
}
