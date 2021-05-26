using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_detalle")]
    public partial class FpedimentoDetalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Required]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Required]
        [Column("descripcion_fraccion")]
        [StringLength(250)]
        public string DescripcionFraccion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Column("orden_partida", TypeName = "numeric(5, 0)")]
        public decimal OrdenPartida { get; set; }
        [Column("valor_comercial", TypeName = "numeric(12, 2)")]
        public decimal ValorComercial { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(15, 3)")]
        public decimal CantidadComercial { get; set; }
        [Required]
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(18, 5)")]
        public decimal CantidadTarifa { get; set; }
        [Required]
        [Column("cve_unidad_tarifa")]
        [StringLength(2)]
        public string CveUnidadTarifa { get; set; }
        [Column("iva", TypeName = "numeric(10, 5)")]
        public decimal? Iva { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("iva_forma_pago1")]
        [StringLength(2)]
        public string IvaFormaPago1 { get; set; }
        [Column("iva_forma_pago2")]
        [StringLength(2)]
        public string IvaFormaPago2 { get; set; }
        [Column("iva_importe1", TypeName = "numeric(12, 0)")]
        public decimal? IvaImporte1 { get; set; }
        [Column("iva_importe2", TypeName = "numeric(12, 0)")]
        public decimal? IvaImporte2 { get; set; }
        [Column("advalorem", TypeName = "numeric(10, 5)")]
        public decimal? Advalorem { get; set; }
        [Column("advalorem_ieps", TypeName = "numeric(10, 5)")]
        public decimal? AdvaloremIeps { get; set; }
        [Column("advalorem_preferencial", TypeName = "numeric(5, 2)")]
        public decimal? AdvaloremPreferencial { get; set; }
        [Column("advalorem_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? AdvaloremPorcentaje { get; set; }
        [Column("advalorem_forma_pago1")]
        [StringLength(2)]
        public string AdvaloremFormaPago1 { get; set; }
        [Column("advalorem_forma_pago2")]
        [StringLength(2)]
        public string AdvaloremFormaPago2 { get; set; }
        [Column("advalorem_importe1", TypeName = "numeric(12, 0)")]
        public decimal? AdvaloremImporte1 { get; set; }
        [Column("advalorem_importe2", TypeName = "numeric(12, 0)")]
        public decimal? AdvaloremImporte2 { get; set; }
        [Column("isan_importe", TypeName = "numeric(12, 0)")]
        public decimal? IsanImporte { get; set; }
        [Column("isan_forma_pago")]
        [StringLength(2)]
        public string IsanFormaPago { get; set; }
        [Column("ieps", TypeName = "numeric(10, 5)")]
        public decimal? Ieps { get; set; }
        [Column("cve_gasolina", TypeName = "numeric(1, 0)")]
        public decimal? CveGasolina { get; set; }
        [Column("ieps_forma_pago")]
        [StringLength(2)]
        public string IepsFormaPago { get; set; }
        [Column("ieps_importe", TypeName = "numeric(12, 0)")]
        public decimal? IepsImporte { get; set; }
        [Column("cuota_comp_forma_pago1")]
        [StringLength(2)]
        public string CuotaCompFormaPago1 { get; set; }
        [Column("cuota_comp_forma_pago2")]
        [StringLength(2)]
        public string CuotaCompFormaPago2 { get; set; }
        [Column("cuota_comp_importe1", TypeName = "numeric(12, 0)")]
        public decimal? CuotaCompImporte1 { get; set; }
        [Column("cuota_comp_importe2", TypeName = "numeric(12, 0)")]
        public decimal? CuotaCompImporte2 { get; set; }
        [Required]
        [Column("uso_edo_mercancia")]
        [StringLength(1)]
        public string UsoEdoMercancia { get; set; }
        [Required]
        [Column("id_vinculacion")]
        [StringLength(1)]
        public string IdVinculacion { get; set; }
        [Required]
        [Column("valoracion")]
        [StringLength(1)]
        public string Valoracion { get; set; }
        [Column("numero_de_orden")]
        [StringLength(28)]
        public string NumeroDeOrden { get; set; }
        [Column("valor_agregado", TypeName = "numeric(12, 0)")]
        public decimal? ValorAgregado { get; set; }
        [Column("factor_azucar", TypeName = "decimal(8, 5)")]
        public decimal? FactorAzucar { get; set; }
        [Column("kgs_azucar", TypeName = "numeric(11, 3)")]
        public decimal? KgsAzucar { get; set; }
        [Column("impuesto_garantia", TypeName = "numeric(16, 0)")]
        public decimal? ImpuestoGarantia { get; set; }
        [Column("sensible")]
        [StringLength(1)]
        public string Sensible { get; set; }
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("folio_aviso")]
        [StringLength(17)]
        public string FolioAviso { get; set; }
        [Column("valor_aduana", TypeName = "numeric(12, 0)")]
        public decimal? ValorAduana { get; set; }
        [Column("valor_comercial_mn", TypeName = "numeric(12, 0)")]
        public decimal? ValorComercialMn { get; set; }
        [Column("precio_detallista", TypeName = "numeric(12, 2)")]
        public decimal? PrecioDetallista { get; set; }
        [Column("precio_estimado")]
        [StringLength(1)]
        public string PrecioEstimado { get; set; }
        [Column("tipo_cuota")]
        [StringLength(1)]
        public string TipoCuota { get; set; }
        [Column("cuota_porcentaje", TypeName = "numeric(10, 5)")]
        public decimal? CuotaPorcentaje { get; set; }
        [Column("cuota_monto_unidad", TypeName = "decimal(15, 10)")]
        public decimal? CuotaMontoUnidad { get; set; }
        [Column("cuota_valor_aduana", TypeName = "numeric(10, 5)")]
        public decimal? CuotaValorAduana { get; set; }
        [Column("peso", TypeName = "numeric(15, 4)")]
        public decimal? Peso { get; set; }
        [Column("identificacion_vehiculo")]
        [StringLength(25)]
        public string IdentificacionVehiculo { get; set; }
        [Column("kilometraje", TypeName = "numeric(5, 0)")]
        public decimal? Kilometraje { get; set; }
        [Column("pago_dta")]
        [StringLength(1)]
        public string PagoDta { get; set; }
        [Column("subdivision_fraccion", TypeName = "numeric(3, 0)")]
        public decimal? SubdivisionFraccion { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo_mercancia")]
        [StringLength(80)]
        public string ModeloMercancia { get; set; }
        [Column("pais_vendedor")]
        [StringLength(3)]
        public string PaisVendedor { get; set; }
        [Column("ent_federativa_origen")]
        [StringLength(3)]
        public string EntFederativaOrigen { get; set; }
        [Column("ent_federativa_destino")]
        [StringLength(3)]
        public string EntFederativaDestino { get; set; }
        [Column("ent_federativa_comprador")]
        [StringLength(3)]
        public string EntFederativaComprador { get; set; }
        [Column("ent_federativa_vendedor")]
        [StringLength(3)]
        public string EntFederativaVendedor { get; set; }
        [Column("cve_tipo_adval")]
        [StringLength(1)]
        public string CveTipoAdval { get; set; }
        [Column("advalorem_azucar", TypeName = "numeric(12, 0)")]
        public decimal? AdvaloremAzucar { get; set; }
        [Column("tipo_arancel")]
        [StringLength(1)]
        public string TipoArancel { get; set; }
        [Column("itv_importe", TypeName = "decimal(12, 0)")]
        public decimal? ItvImporte { get; set; }
        [Column("itv_fp")]
        [StringLength(2)]
        public string ItvFp { get; set; }
        [Column("tasa_ieps")]
        [StringLength(2)]
        public string TasaIeps { get; set; }
        [Column("tasa_isan", TypeName = "decimal(4, 3)")]
        public decimal? TasaIsan { get; set; }
        [Column("tasa_itv", TypeName = "decimal(4, 3)")]
        public decimal? TasaItv { get; set; }
        [Column("mt_tasa", TypeName = "numeric(5, 2)")]
        public decimal? MtTasa { get; set; }
        [Column("mt_valor_minimo", TypeName = "numeric(8, 2)")]
        public decimal? MtValorMinimo { get; set; }
        [Column("mt_forma_pago")]
        [StringLength(2)]
        public string MtFormaPago { get; set; }
        [Column("mt_importe", TypeName = "numeric(12, 0)")]
        public decimal? MtImporte { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("id_producto_factura")]
        [StringLength(50)]
        public string IdProductoFactura { get; set; }
        [Column("valor", TypeName = "decimal(12, 2)")]
        public decimal? Valor { get; set; }
        [Column("id_moneda_valor")]
        [StringLength(4)]
        public string IdMonedaValor { get; set; }
        [Column("factor_moneda", TypeName = "decimal(10, 8)")]
        public decimal? FactorMoneda { get; set; }
        [Column("cantidad_prod", TypeName = "decimal(18, 5)")]
        public decimal? CantidadProd { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("dta_fraccion", TypeName = "numeric(17, 5)")]
        public decimal DtaFraccion { get; set; }
        [Column("pesos_x_litro", TypeName = "decimal(10, 2)")]
        public decimal PesosXLitro { get; set; }
        [Column("cantidad_litros", TypeName = "decimal(15, 3)")]
        public decimal CantidadLitros { get; set; }
        [Column("valor_retornos", TypeName = "numeric(12, 2)")]
        public decimal? ValorRetornos { get; set; }
        [Column("sub_fraccion")]
        [StringLength(2)]
        public string SubFraccion { get; set; }
        [Column("tipo_tasa_cc")]
        [StringLength(2)]
        public string TipoTasaCc { get; set; }
        [Column("igi_importe_compe", TypeName = "decimal(12, 0)")]
        public decimal? IgiImporteCompe { get; set; }
        [Column("iva_importe_compe", TypeName = "decimal(12, 0)")]
        public decimal? IvaImporteCompe { get; set; }
        [Column("tipo_moneda_ieps")]
        [StringLength(3)]
        public string TipoMonedaIeps { get; set; }
        [Column("tipo_ieps")]
        [StringLength(1)]
        public string TipoIeps { get; set; }
    }
}
