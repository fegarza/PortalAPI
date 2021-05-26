using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgfactura")]
    [Index(nameof(Rowguid), Name = "index_1694629080", IsUnique = true)]
    public partial class Fgfactura
    {
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Key]
        [Column("id_entrada_bodega")]
        [StringLength(10)]
        public string IdEntradaBodega { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Required]
        [Column("id_pais_moneda")]
        [StringLength(4)]
        public string IdPaisMoneda { get; set; }
        [Column("valor_factura", TypeName = "numeric(15, 6)")]
        public decimal? ValorFactura { get; set; }
        [Column("peso_kgs", TypeName = "numeric(11, 2)")]
        public decimal PesoKgs { get; set; }
        [Column("peso_lbs", TypeName = "numeric(11, 2)")]
        public decimal PesoLbs { get; set; }
        [Column("importe_flete", TypeName = "numeric(11, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("importe_otros", TypeName = "numeric(11, 2)")]
        public decimal ImporteOtros { get; set; }
        [Column("importe_seguro", TypeName = "numeric(11, 2)")]
        public decimal ImporteSeguro { get; set; }
        [Required]
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Required]
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Required]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("descuentos", TypeName = "numeric(11, 2)")]
        public decimal? Descuentos { get; set; }
        [Column("estado_factura")]
        [StringLength(1)]
        public string EstadoFactura { get; set; }
        [Column("factor_comercial", TypeName = "numeric(10, 8)")]
        public decimal? FactorComercial { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("factor_flete", TypeName = "numeric(10, 8)")]
        public decimal? FactorFlete { get; set; }
        [Column("id_moneda_seguro")]
        [StringLength(4)]
        public string IdMonedaSeguro { get; set; }
        [Column("factor_seguro", TypeName = "numeric(10, 8)")]
        public decimal? FactorSeguro { get; set; }
        [Column("id_moneda_otros")]
        [StringLength(4)]
        public string IdMonedaOtros { get; set; }
        [Column("factor_otros", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtros { get; set; }
        [Column("id_moneda_descuento")]
        [StringLength(4)]
        public string IdMonedaDescuento { get; set; }
        [Column("factor_descuento", TypeName = "numeric(10, 8)")]
        public decimal? FactorDescuento { get; set; }
        [Column("destino_icoterm")]
        [StringLength(20)]
        public string DestinoIcoterm { get; set; }
        [Column("fecha_recibo", TypeName = "datetime")]
        public DateTime? FechaRecibo { get; set; }
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [StringLength(20)]
        public string Familia { get; set; }
        [Column("Sales_Order")]
        [StringLength(20)]
        public string SalesOrder { get; set; }
        [Column("id_usuario_rev")]
        [StringLength(6)]
        public string IdUsuarioRev { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_tipo")]
        [StringLength(4)]
        public string IdTipo { get; set; }
        [Column("planta")]
        [StringLength(6)]
        public string Planta { get; set; }
        [Column("fecha_revision", TypeName = "datetime")]
        public DateTime? FechaRevision { get; set; }
        [Column("id_prefigo")]
        public long? IdPrefigo { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("id_proforma")]
        [StringLength(15)]
        public string IdProforma { get; set; }
        [Column("id_prefijo")]
        public long? IdPrefijo { get; set; }
        [Column("TRANSPORTISTA")]
        [StringLength(40)]
        public string Transportista { get; set; }
        [Column("usuario_autoriza")]
        [StringLength(10)]
        public string UsuarioAutoriza { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("id_ref_cove")]
        [StringLength(10)]
        public string IdRefCove { get; set; }
        [Column("importe_flete_mv", TypeName = "numeric(11, 2)")]
        public decimal? ImporteFleteMv { get; set; }
        [Column("importe_seguro_mv", TypeName = "numeric(11, 2)")]
        public decimal? ImporteSeguroMv { get; set; }
        [Column("importe_otros_mv", TypeName = "numeric(11, 2)")]
        public decimal? ImporteOtrosMv { get; set; }
        [Column("id_moneda_flete_mv")]
        [StringLength(4)]
        public string IdMonedaFleteMv { get; set; }
        [Column("id_moneda_seguro_mv")]
        [StringLength(4)]
        public string IdMonedaSeguroMv { get; set; }
        [Column("id_moneda_otros_mv")]
        [StringLength(4)]
        public string IdMonedaOtrosMv { get; set; }
        [Column("factor_flete_mv", TypeName = "numeric(10, 8)")]
        public decimal? FactorFleteMv { get; set; }
        [Column("factor_seguro_mv", TypeName = "numeric(10, 8)")]
        public decimal? FactorSeguroMv { get; set; }
        [Column("factor_otros_mv", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtrosMv { get; set; }
        [Column("factor_embalaje", TypeName = "numeric(10, 8)")]
        public decimal? FactorEmbalaje { get; set; }
        [Column("id_moneda_embalaje")]
        [StringLength(4)]
        public string IdMonedaEmbalaje { get; set; }
        [Column("importe_embalaje", TypeName = "numeric(11, 2)")]
        public decimal? ImporteEmbalaje { get; set; }
        [Column("importe_embalaje_mv", TypeName = "numeric(11, 2)")]
        public decimal? ImporteEmbalajeMv { get; set; }
        [Column("id_moneda_embalaje_mv")]
        [StringLength(4)]
        public string IdMonedaEmbalajeMv { get; set; }
        [Column("factor_embalaje_mv", TypeName = "numeric(10, 8)")]
        public decimal? FactorEmbalajeMv { get; set; }
        [Column("notificacion_correo")]
        [StringLength(1)]
        public string NotificacionCorreo { get; set; }
        [Column("pedimento_original")]
        [StringLength(7)]
        public string PedimentoOriginal { get; set; }
        [Column("entrada_original")]
        [StringLength(10)]
        public string EntradaOriginal { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime? FechaCaptura { get; set; }
        [Column("inbond")]
        [StringLength(1)]
        public string Inbond { get; set; }
        [Column("factura_original")]
        [StringLength(36)]
        public string FacturaOriginal { get; set; }
        [Column("rfc_receptor")]
        [StringLength(13)]
        public string RfcReceptor { get; set; }
        [Column("fecha_val_cfdi", TypeName = "datetime")]
        public DateTime? FechaValCfdi { get; set; }
        [Column("id_usuario_val_cfdi")]
        [StringLength(6)]
        public string IdUsuarioValCfdi { get; set; }
        [Column("amazon_ship_id")]
        [StringLength(60)]
        public string AmazonShipId { get; set; }
        [Column("factura_aux")]
        [StringLength(36)]
        public string FacturaAux { get; set; }
        [StringLength(1)]
        public string Mayuscula { get; set; }
        [Column("proveedor_certifica")]
        [StringLength(50)]
        public string ProveedorCertifica { get; set; }

        [ForeignKey(nameof(IdProveedor))]
        [InverseProperty(nameof(Fproveedor.Fgfacturas))]
        public virtual Fproveedor IdProveedorNavigation { get; set; }
        [ForeignKey(nameof(IdTipoFactura))]
        [InverseProperty(nameof(FtipoFactura.Fgfacturas))]
        public virtual FtipoFactura IdTipoFacturaNavigation { get; set; }
    }
}
