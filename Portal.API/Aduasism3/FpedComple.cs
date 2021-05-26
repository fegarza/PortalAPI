using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_comple")]
    [Index(nameof(Rowguid), Name = "index_699201591", IsUnique = true)]
    public partial class FpedComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Required]
        [Column("prevalidador")]
        [StringLength(5)]
        public string Prevalidador { get; set; }
        [Required]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("cve_regimen")]
        [StringLength(3)]
        public string CveRegimen { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime FechaPago { get; set; }
        [Column("fecha_rectificacion", TypeName = "datetime")]
        public DateTime? FechaRectificacion { get; set; }
        [Required]
        [Column("id_patente_exp")]
        [StringLength(4)]
        public string IdPatenteExp { get; set; }
        [Column("pedimento_exp")]
        [StringLength(7)]
        public string PedimentoExp { get; set; }
        [Required]
        [Column("id_aduana_exp")]
        [StringLength(2)]
        public string IdAduanaExp { get; set; }
        [Required]
        [Column("seccion_exp")]
        [StringLength(1)]
        public string SeccionExp { get; set; }
        [Column("id_regimen_exp")]
        [StringLength(2)]
        public string IdRegimenExp { get; set; }
        [Column("fecha_pago_exp", TypeName = "datetime")]
        public DateTime FechaPagoExp { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("razon_social_cliente")]
        [StringLength(120)]
        public string RazonSocialCliente { get; set; }
        [Required]
        [Column("rfc_cliente")]
        [StringLength(13)]
        public string RfcCliente { get; set; }
        [Column("curp_imp")]
        [StringLength(18)]
        public string CurpImp { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 5)")]
        public decimal TipoCambio { get; set; }
        [Column("firma_shcp")]
        [StringLength(8)]
        public string FirmaShcp { get; set; }
        [Column("firma_banco")]
        [StringLength(10)]
        public string FirmaBanco { get; set; }
        [Column("importe_efectivo", TypeName = "decimal(12, 0)")]
        public decimal? ImporteEfectivo { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 0)")]
        public decimal? ImporteOtros { get; set; }
        [Column("nombre_agente_ad")]
        [StringLength(120)]
        public string NombreAgenteAd { get; set; }
        [Column("rfc_ag_ad")]
        [StringLength(13)]
        public string RfcAgAd { get; set; }
        [Column("curp_ag_ad")]
        [StringLength(18)]
        public string CurpAgAd { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("apoderado")]
        [StringLength(120)]
        public string Apoderado { get; set; }
        [Column("rfc_apoderado")]
        [StringLength(13)]
        public string RfcApoderado { get; set; }
        [Column("curp_apoderado")]
        [StringLength(18)]
        public string CurpApoderado { get; set; }
        [Column("id_banco")]
        [StringLength(2)]
        public string IdBanco { get; set; }
        [Column("banco_nombre")]
        [StringLength(50)]
        public string BancoNombre { get; set; }
        [Column("caja_banco")]
        [StringLength(3)]
        public string CajaBanco { get; set; }
        [Column("opn_banco")]
        [StringLength(10)]
        public string OpnBanco { get; set; }
        [Column("fecha_pago_banco", TypeName = "datetime")]
        public DateTime? FechaPagoBanco { get; set; }
        [Column("importe_banco", TypeName = "decimal(12, 0)")]
        public decimal? ImporteBanco { get; set; }
        [Column("factor_actualizacion", TypeName = "decimal(10, 8)")]
        public decimal? FactorActualizacion { get; set; }
        [Column("dta_tipo_tasa")]
        [StringLength(2)]
        public string DtaTipoTasa { get; set; }
        [Column("dta_tasa", TypeName = "decimal(12, 0)")]
        public decimal? DtaTasa { get; set; }
        [Column("dta_forma_pago")]
        [StringLength(2)]
        public string DtaFormaPago { get; set; }
        [Column("recargo_tipo_tasa")]
        [StringLength(2)]
        public string RecargoTipoTasa { get; set; }
        [Column("recargo_tasa", TypeName = "decimal(10, 5)")]
        public decimal? RecargoTasa { get; set; }
        [Column("recargo_forma_pago")]
        [StringLength(2)]
        public string RecargoFormaPago { get; set; }
        [Column("prevalidacion_tipo_tasa")]
        [StringLength(2)]
        public string PrevalidacionTipoTasa { get; set; }
        [Column("prevalidacion_tasa", TypeName = "decimal(12, 0)")]
        public decimal? PrevalidacionTasa { get; set; }
        [Column("prevalidacion_forma_pago")]
        [StringLength(2)]
        public string PrevalidacionFormaPago { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Column("tipo_figura_ped")]
        [StringLength(1)]
        public string TipoFiguraPed { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("firma_pedimento")]
        [StringLength(250)]
        public string FirmaPedimento { get; set; }
        [Column("ruta_archivo")]
        [StringLength(100)]
        public string RutaArchivo { get; set; }
        [Column("num_serie")]
        [StringLength(30)]
        public string NumSerie { get; set; }
        [Column("id_usuario_gen")]
        [StringLength(6)]
        public string IdUsuarioGen { get; set; }
        [Column("fecha_gen", TypeName = "datetime")]
        public DateTime? FechaGen { get; set; }
        [Column("id_usuario_ult_gen")]
        [StringLength(6)]
        public string IdUsuarioUltGen { get; set; }
        [Column("fecha_ult_gen", TypeName = "datetime")]
        public DateTime? FechaUltGen { get; set; }
        [Column("rfc_servicios")]
        [StringLength(13)]
        public string RfcServicios { get; set; }
        [Column("contrapres_importe", TypeName = "decimal(12, 0)")]
        public decimal? ContrapresImporte { get; set; }
        [Column("contrapres_tasa", TypeName = "decimal(12, 0)")]
        public decimal? ContrapresTasa { get; set; }
        [Column("razon_social_servicios")]
        [StringLength(120)]
        public string RazonSocialServicios { get; set; }
    }
}
