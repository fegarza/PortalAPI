using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_generales")]
    public partial class OcGenerale
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_fraccion_generica")]
        [StringLength(8)]
        public string IdFraccionGenerica { get; set; }
        [Column("descripcion_generica")]
        [StringLength(250)]
        public string DescripcionGenerica { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("factor_seguros", TypeName = "decimal(6, 4)")]
        public decimal? FactorSeguros { get; set; }
        [Column("destinatario")]
        [StringLength(50)]
        public string Destinatario { get; set; }
        [Column("dias_almacenaje")]
        public int DiasAlmacenaje { get; set; }
        [Column("dias_expiracion")]
        public int DiasExpiracion { get; set; }
        [Column("fecha_expiracion", TypeName = "datetime")]
        public DateTime? FechaExpiracion { get; set; }
        [Column("requiere_previo")]
        public bool RequierePrevio { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Column("etiquetar_asn")]
        public bool EtiquetarAsn { get; set; }
        [Column("tipo_carga")]
        [StringLength(2)]
        public string TipoCarga { get; set; }
        [Column("id_consignatario")]
        [StringLength(10)]
        public string IdConsignatario { get; set; }
        [Column("validar_regimen")]
        public bool ValidarRegimen { get; set; }
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("factura_consolidacion")]
        public bool FacturaConsolidacion { get; set; }
        [Column("doc_pedimento_pago")]
        public bool? DocPedimentoPago { get; set; }
        [Column("limite")]
        public short Limite { get; set; }
        [Column("xml_exportacion_descripcion_producto")]
        public bool XmlExportacionDescripcionProducto { get; set; }
        [Column("clasificacion_factura")]
        public bool ClasificacionFactura { get; set; }
        [Column("clave_documento")]
        [StringLength(5)]
        public string ClaveDocumento { get; set; }
        [Column("instruccion_autorizada")]
        public bool? InstruccionAutorizada { get; set; }
        [Column("valida_oc")]
        public bool? ValidaOc { get; set; }
        [Column("notificar_proveedor")]
        public bool? NotificarProveedor { get; set; }
        [Column("requiere_packing")]
        public bool? RequierePacking { get; set; }
        [Column("departamento")]
        [StringLength(1)]
        public string Departamento { get; set; }
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("notificacion_proveedor")]
        public bool? NotificacionProveedor { get; set; }
        [Column("quitar_cero")]
        public bool QuitarCero { get; set; }
        [Column("tipo_importacion")]
        [StringLength(1)]
        public string TipoImportacion { get; set; }
        [Column("validacion_adicional_fac_impo")]
        public bool? ValidacionAdicionalFacImpo { get; set; }
        [Required]
        [Column("manifiesto_carga")]
        public bool? ManifiestoCarga { get; set; }
        [Column("packing_asn")]
        public bool PackingAsn { get; set; }
        [Column("id_corresponsal")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Column("requiere_incoterm")]
        public bool? RequiereIncoterm { get; set; }
        [Column("factura_packing")]
        public bool? FacturaPacking { get; set; }
        [Column("crear_packing_factura_impo")]
        public bool? CrearPackingFacturaImpo { get; set; }
        [Column("fecha_cambio_po")]
        public bool FechaCambioPo { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("session_aduana")]
        [StringLength(1)]
        public string SessionAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Column("notificacion_osd_guia_packing")]
        public bool NotificacionOsdGuiaPacking { get; set; }
        [Column("oe_id_almacen")]
        [StringLength(8)]
        public string OeIdAlmacen { get; set; }
        [Column("oe_tipo_transporte")]
        [StringLength(2)]
        public string OeTipoTransporte { get; set; }
        [Column("oe_id_agencia")]
        [StringLength(4)]
        public string OeIdAgencia { get; set; }
        [Column("oe_id_linea_fletera")]
        [StringLength(4)]
        public string OeIdLineaFletera { get; set; }
        [Column("oe_numero_vehiculo")]
        [StringLength(20)]
        public string OeNumeroVehiculo { get; set; }
        [Column("oe_id_tipo_vehiculo")]
        [StringLength(2)]
        public string OeIdTipoVehiculo { get; set; }
        [Column("oe_numero_guia")]
        [StringLength(35)]
        public string OeNumeroGuia { get; set; }
        [Column("oe_clase_material")]
        public short? OeClaseMaterial { get; set; }
        [Column("oe_id_localizacion")]
        [StringLength(15)]
        public string OeIdLocalizacion { get; set; }
        [Column("factura_exportacion_asociar_peso_bultos")]
        public bool? FacturaExportacionAsociarPesoBultos { get; set; }
        [Column("packing_facturado_obligatorio")]
        public bool? PackingFacturadoObligatorio { get; set; }
        [Column("po_mixta")]
        public bool PoMixta { get; set; }
        [Column("referencia_auxiliar")]
        public bool? ReferenciaAuxiliar { get; set; }
        [Column("autodoc_recibo")]
        public bool? AutodocRecibo { get; set; }
        [Column("po_obligatoria")]
        public bool? PoObligatoria { get; set; }
        [Column("cliente_con_planta")]
        public bool? ClienteConPlanta { get; set; }
        [Column("id_nico_generico")]
        [StringLength(2)]
        public string IdNicoGenerico { get; set; }
        [Column("validar_pedimento_master")]
        public bool? ValidarPedimentoMaster { get; set; }
        [Column("consecutivo_auto_referencia_aux")]
        public bool? ConsecutivoAutoReferenciaAux { get; set; }
        [Column("consecutivo_referencia_aux")]
        public int? ConsecutivoReferenciaAux { get; set; }
        [Column("no_caracteres_referencia_aux")]
        public short? NoCaracteresReferenciaAux { get; set; }
        [Column("requiere_embarcador")]
        public bool RequiereEmbarcador { get; set; }
        [Column("actualiza_fraccion_layout_exportacion")]
        public bool ActualizaFraccionLayoutExportacion { get; set; }
        [Column("clonar_producto_proveedor")]
        public bool ClonarProductoProveedor { get; set; }
        [Column("oe_cargar_generales_almacen_operacion")]
        public bool? OeCargarGeneralesAlmacenOperacion { get; set; }
        [Column("no_repetir_factura")]
        public bool? NoRepetirFactura { get; set; }
        [Column("log_anden_descarga")]
        public bool LogAndenDescarga { get; set; }
        [Column("id_linea_fletera_distribucion")]
        [StringLength(4)]
        public string IdLineaFleteraDistribucion { get; set; }
        [Column("min_digitos_bol_distribucion")]
        public short? MinDigitosBolDistribucion { get; set; }
    }
}
