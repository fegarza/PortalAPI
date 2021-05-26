using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("email_contactos_cliente")]
    public partial class EmailContactosCliente
    {
        [Key]
        [Column("id_contacto", TypeName = "numeric(18, 0)")]
        public decimal IdContacto { get; set; }
        [Key]
        [Column("cliente")]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Column("email")]
        [StringLength(200)]
        public string Email { get; set; }
        [Column("notificacion_entrada")]
        [StringLength(1)]
        public string NotificacionEntrada { get; set; }
        [Column("notificacion_embarque")]
        [StringLength(1)]
        public string NotificacionEmbarque { get; set; }
        [Required]
        [Column("notificacion_eventos")]
        [StringLength(1)]
        public string NotificacionEventos { get; set; }
        [Column("notificacion_fac_elec")]
        [StringLength(1)]
        public string NotificacionFacElec { get; set; }
        [Column("notificacion_ferrocarril")]
        [StringLength(1)]
        public string NotificacionFerrocarril { get; set; }
        [Column("notificacion_pedimento")]
        [StringLength(1)]
        public string NotificacionPedimento { get; set; }
        [Column("notificacion_pedimento_txt")]
        [StringLength(1)]
        public string NotificacionPedimentoTxt { get; set; }
        [Column("notifi_cop_imp_fir_ban")]
        [StringLength(1)]
        public string NotifiCopImpFirBan { get; set; }
        [Column("eventos_aduana")]
        [StringLength(1)]
        public string EventosAduana { get; set; }
        [Column("remesas")]
        [StringLength(1)]
        public string Remesas { get; set; }
        [Column("proforma")]
        [StringLength(1)]
        public string Proforma { get; set; }
        [Column("fac_elec_op")]
        [StringLength(1)]
        public string FacElecOp { get; set; }
        [Column("entrada_op")]
        [StringLength(1)]
        public string EntradaOp { get; set; }
        [Column("embarque_op")]
        [StringLength(1)]
        public string EmbarqueOp { get; set; }
        [Column("eventos_op")]
        [StringLength(1)]
        public string EventosOp { get; set; }
        [Column("ferrocarril_op")]
        [StringLength(1)]
        public string FerrocarrilOp { get; set; }
        [Column("pedimento_op")]
        [StringLength(1)]
        public string PedimentoOp { get; set; }
        [Column("eventos_interno_op")]
        [StringLength(1)]
        public string EventosInternoOp { get; set; }
        [Column("relacion")]
        [StringLength(1)]
        public string Relacion { get; set; }
        [Column("relacion_op")]
        [StringLength(1)]
        public string RelacionOp { get; set; }
        [Column("notifica_entrada_wms")]
        public bool? NotificaEntradaWms { get; set; }
        [Column("orden_remision")]
        [StringLength(1)]
        public string OrdenRemision { get; set; }
        [Column("orden_remision_op")]
        [StringLength(1)]
        public string OrdenRemisionOp { get; set; }
        [Column("envio_archivos")]
        [StringLength(1)]
        public string EnvioArchivos { get; set; }
        [Column("notifi_cop_imp_fir_ban_op")]
        [StringLength(1)]
        public string NotifiCopImpFirBanOp { get; set; }
        [Column("factura_cliente")]
        public bool? FacturaCliente { get; set; }
        [Column("notificacion_mv")]
        [StringLength(1)]
        public string NotificacionMv { get; set; }
        [Column("notificacion_hc")]
        [StringLength(1)]
        public string NotificacionHc { get; set; }
        [Column("operacion_mv")]
        [StringLength(1)]
        public string OperacionMv { get; set; }
        [Column("operacion_hc")]
        [StringLength(1)]
        public string OperacionHc { get; set; }
        [Column("rectificacion")]
        [StringLength(1)]
        public string Rectificacion { get; set; }
        [Column("rectificacion_op")]
        [StringLength(1)]
        public string RectificacionOp { get; set; }
        [Column("vulnerable_op")]
        [StringLength(1)]
        public string VulnerableOp { get; set; }
        [Column("vulnerable")]
        [StringLength(1)]
        public string Vulnerable { get; set; }
        [Column("economia_op")]
        [StringLength(1)]
        public string EconomiaOp { get; set; }
        [Column("economia")]
        [StringLength(1)]
        public string Economia { get; set; }
        [Column("factura")]
        [StringLength(1)]
        public string Factura { get; set; }
        [Column("factura_op")]
        [StringLength(1)]
        public string FacturaOp { get; set; }
        [Required]
        [Column("notificacion_clasificacion_entrada")]
        [StringLength(1)]
        public string NotificacionClasificacionEntrada { get; set; }
        [Required]
        [Column("notificacion_clasificacion_entrada_op")]
        [StringLength(1)]
        public string NotificacionClasificacionEntradaOp { get; set; }
        [Column("notificacion_ral")]
        [StringLength(1)]
        public string NotificacionRal { get; set; }
        [Column("notificacion_ral_op")]
        [StringLength(1)]
        public string NotificacionRalOp { get; set; }
        [Column("eventos_aduana_por_dia")]
        [StringLength(1)]
        public string EventosAduanaPorDia { get; set; }
        [Column("cove_firma_banco")]
        [StringLength(1)]
        public string CoveFirmaBanco { get; set; }
        [Column("cove_firma_banco_op")]
        [StringLength(1)]
        public string CoveFirmaBancoOp { get; set; }
        [Column("notificacion_clasificacion")]
        [StringLength(1)]
        public string NotificacionClasificacion { get; set; }
        [Column("notificacion_cambio_fraccion")]
        [StringLength(1)]
        public string NotificacionCambioFraccion { get; set; }
        [Column("notificacion_cambio_fraccion_op")]
        [StringLength(1)]
        public string NotificacionCambioFraccionOp { get; set; }
        [Column("notificacion_clasificacion_op")]
        [StringLength(1)]
        public string NotificacionClasificacionOp { get; set; }
        [Column("fraccion_sensible")]
        [StringLength(1)]
        public string FraccionSensible { get; set; }
        [Column("fraccion_sensible_op")]
        [StringLength(1)]
        public string FraccionSensibleOp { get; set; }
        [Column("envio_doctos")]
        [StringLength(1)]
        public string EnvioDoctos { get; set; }
        [Column("envio_doctos_opn")]
        [StringLength(1)]
        public string EnvioDoctosOpn { get; set; }
        [Column("notificacion_previo")]
        [StringLength(1)]
        public string NotificacionPrevio { get; set; }
        [Column("envio_rel_doctos")]
        [StringLength(1)]
        public string EnvioRelDoctos { get; set; }
        [Column("envio_rel_doctos_opn")]
        [StringLength(1)]
        public string EnvioRelDoctosOpn { get; set; }
    }
}
