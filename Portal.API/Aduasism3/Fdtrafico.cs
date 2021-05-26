using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdtrafico")]
    [Index(nameof(IdEntrada), nameof(IdFactura), nameof(IdPackList), Name = "Indx_fdtrafico_id_entrada_id_factura_id_pack_list")]
    [Index(nameof(Rowguid), Name = "index_529436960", IsUnique = true)]
    public partial class Fdtrafico
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "decimal(4, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Required]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("cantidad_prod", TypeName = "decimal(12, 5)")]
        public decimal CantidadProd { get; set; }
        [Column("importe", TypeName = "decimal(12, 2)")]
        public decimal Importe { get; set; }
        [Required]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Column("id_shipper")]
        [StringLength(8)]
        public string IdShipper { get; set; }
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Column("numero_secuencial_factura", TypeName = "decimal(4, 0)")]
        public decimal? NumeroSecuencialFactura { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("descripcion_clasificacion")]
        [StringLength(250)]
        public string DescripcionClasificacion { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(14, 3)")]
        public decimal? CantidadComercial { get; set; }
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(18, 5)")]
        public decimal? CantidadTarifa { get; set; }
        [Column("cve_unidad_tarifa")]
        [StringLength(2)]
        public string CveUnidadTarifa { get; set; }
        [Column("iva", TypeName = "decimal(4, 2)")]
        public decimal? Iva { get; set; }
        [Column("iva_porcentaje", TypeName = "decimal(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("iva_forma_pago1")]
        [StringLength(2)]
        public string IvaFormaPago1 { get; set; }
        [Column("iva_forma_pago2")]
        [StringLength(2)]
        public string IvaFormaPago2 { get; set; }
        [Column("advalorem", TypeName = "decimal(6, 3)")]
        public decimal? Advalorem { get; set; }
        [Column("advalorem_ieps", TypeName = "decimal(6, 3)")]
        public decimal? AdvaloremIeps { get; set; }
        [Column("advalorem_preferencial", TypeName = "decimal(5, 2)")]
        public decimal? AdvaloremPreferencial { get; set; }
        [Column("advalorem_porcentaje", TypeName = "decimal(5, 2)")]
        public decimal? AdvaloremPorcentaje { get; set; }
        [Column("advalorem_forma_pago1")]
        [StringLength(2)]
        public string AdvaloremFormaPago1 { get; set; }
        [Column("advalorem_forma_pago2")]
        [StringLength(2)]
        public string AdvaloremFormaPago2 { get; set; }
        [Column("isan_importe", TypeName = "decimal(12, 0)")]
        public decimal? IsanImporte { get; set; }
        [Column("isan_forma_pago")]
        [StringLength(2)]
        public string IsanFormaPago { get; set; }
        [Column("ieps", TypeName = "decimal(5, 2)")]
        public decimal? Ieps { get; set; }
        [Column("cve_gasolina", TypeName = "decimal(1, 0)")]
        public decimal? CveGasolina { get; set; }
        [Column("ieps_forma_pago")]
        [StringLength(2)]
        public string IepsFormaPago { get; set; }
        [Column("cuota_comp_forma_pago1")]
        [StringLength(2)]
        public string CuotaCompFormaPago1 { get; set; }
        [Column("cuota_comp_forma_pago2")]
        [StringLength(2)]
        public string CuotaCompFormaPago2 { get; set; }
        [Column("uso_edo_mercancia")]
        [StringLength(1)]
        public string UsoEdoMercancia { get; set; }
        [Column("id_vinculacion")]
        [StringLength(1)]
        public string IdVinculacion { get; set; }
        [Column("valoracion")]
        [StringLength(1)]
        public string Valoracion { get; set; }
        [Column("valor_agregado", TypeName = "decimal(12, 0)")]
        public decimal? ValorAgregado { get; set; }
        [Column("factor_azucar", TypeName = "decimal(7, 5)")]
        public decimal? FactorAzucar { get; set; }
        [Column("kgs_azucar", TypeName = "decimal(11, 3)")]
        public decimal? KgsAzucar { get; set; }
        [Column("proveedor_trafico")]
        [StringLength(6)]
        public string ProveedorTrafico { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [StringLength(1)]
        public string Agrupar { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal? Partida { get; set; }
        [Column("Clasificacion_fisica")]
        [StringLength(1)]
        public string ClasificacionFisica { get; set; }
        [StringLength(1)]
        public string Sensible { get; set; }
        [Column("precio_detallista", TypeName = "decimal(12, 2)")]
        public decimal? PrecioDetallista { get; set; }
        [Column("precio_estimado")]
        [StringLength(1)]
        public string PrecioEstimado { get; set; }
        [Column("tipo_cuota")]
        [StringLength(1)]
        public string TipoCuota { get; set; }
        [Column("cuota_porcentaje", TypeName = "decimal(5, 2)")]
        public decimal? CuotaPorcentaje { get; set; }
        [Column("cuota_monto_unidad", TypeName = "decimal(10, 4)")]
        public decimal? CuotaMontoUnidad { get; set; }
        [Column("cuota_valor_aduana", TypeName = "decimal(5, 2)")]
        public decimal? CuotaValorAduana { get; set; }
        [Column("peso", TypeName = "decimal(15, 4)")]
        public decimal? Peso { get; set; }
        [Column("subpar_sn")]
        [StringLength(1)]
        public string SubparSn { get; set; }
        [Column("id_pais_vendedor")]
        [StringLength(4)]
        public string IdPaisVendedor { get; set; }
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
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(80)]
        public string Modelo { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("id_referencia_conso")]
        [StringLength(10)]
        public string IdReferenciaConso { get; set; }
        [Column("id_rectificacion_conso")]
        public int? IdRectificacionConso { get; set; }
        [Column("consecutivo_remesa")]
        public int? ConsecutivoRemesa { get; set; }
        [Column("pesos_x_litro", TypeName = "decimal(10, 2)")]
        public decimal PesosXLitro { get; set; }
        [Column("pallet_number")]
        [StringLength(25)]
        public string PalletNumber { get; set; }
        [Column("carton_number")]
        [StringLength(25)]
        public string CartonNumber { get; set; }
        [Column("remesa_portal", TypeName = "numeric(5, 0)")]
        public decimal? RemesaPortal { get; set; }
        [Column("regla8")]
        [StringLength(1)]
        public string Regla8 { get; set; }
        [Column("tl")]
        [StringLength(1)]
        public string Tl { get; set; }
        [Column("cantidad_ieps", TypeName = "numeric(18, 5)")]
        public decimal? CantidadIeps { get; set; }
        [Column("tipo_moneda_ieps")]
        [StringLength(3)]
        public string TipoMonedaIeps { get; set; }
        [Column("tipo_ieps")]
        [StringLength(1)]
        public string TipoIeps { get; set; }
        [Column("nico")]
        [StringLength(2)]
        public string Nico { get; set; }

        [ForeignKey(nameof(IdProveedor))]
        [InverseProperty(nameof(Fproveedor.Fdtraficos))]
        public virtual Fproveedor IdProveedorNavigation { get; set; }
        [ForeignKey(nameof(IdTipoAdvalorem))]
        [InverseProperty(nameof(FtipoAdvalorem.Fdtraficos))]
        public virtual FtipoAdvalorem IdTipoAdvaloremNavigation { get; set; }
    }
}
