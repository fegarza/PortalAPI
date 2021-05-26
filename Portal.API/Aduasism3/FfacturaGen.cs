using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffactura_gen")]
    public partial class FfacturaGen
    {
        [Key]
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Required]
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Required]
        [Column("id_pais_moneda")]
        [StringLength(4)]
        public string IdPaisMoneda { get; set; }
        [Column("valor_factura", TypeName = "numeric(11, 2)")]
        public decimal ValorFactura { get; set; }
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
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("destinatario")]
        [StringLength(6)]
        public string Destinatario { get; set; }
        [Column("moneda_valor_fact")]
        [StringLength(4)]
        public string MonedaValorFact { get; set; }
        [Column("subtotal_factura", TypeName = "decimal(18, 2)")]
        public decimal? SubtotalFactura { get; set; }
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("valor_agregado", TypeName = "decimal(12, 6)")]
        public decimal? ValorAgregado { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("moneda_iva")]
        [StringLength(4)]
        public string MonedaIva { get; set; }
        [Column("cant_bultos", TypeName = "numeric(8, 0)")]
        public decimal? CantBultos { get; set; }
        [Column("no_pallet")]
        [StringLength(18)]
        public string NoPallet { get; set; }
        [Column("planta")]
        [StringLength(6)]
        public string Planta { get; set; }
        [Column("peso_neto", TypeName = "numeric(14, 3)")]
        public decimal? PesoNeto { get; set; }
        [Column("peso_neto_lbs", TypeName = "numeric(14, 3)")]
        public decimal? PesoNetoLbs { get; set; }
        [Column("id_destino")]
        [StringLength(3)]
        public string IdDestino { get; set; }
        [Column("dealer_number")]
        [StringLength(5)]
        public string DealerNumber { get; set; }
        [Column("distfd")]
        [StringLength(7)]
        public string Distfd { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("id_consecutivo", TypeName = "numeric(10, 0)")]
        public decimal IdConsecutivo { get; set; }
        [Column("sub_doc")]
        [StringLength(1)]
        public string SubDoc { get; set; }
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Column("cantidad", TypeName = "numeric(5, 0)")]
        public decimal? Cantidad { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal? Consecutivo { get; set; }
        [Column("id_ref_cove")]
        [StringLength(10)]
        public string IdRefCove { get; set; }
        [Column("nombre_EDI")]
        [StringLength(20)]
        public string NombreEdi { get; set; }
        [Column("fecha_EDI", TypeName = "datetime")]
        public DateTime? FechaEdi { get; set; }
        [Column("fecha_PDF", TypeName = "datetime")]
        public DateTime? FechaPdf { get; set; }
    }
}
