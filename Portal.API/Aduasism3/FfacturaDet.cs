using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffactura_det")]
    public partial class FfacturaDet
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
        [Column("num_detalle", TypeName = "decimal(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Required]
        [Column("id_orden_compra")]
        [StringLength(15)]
        public string IdOrdenCompra { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("precio_unitario", TypeName = "decimal(14, 6)")]
        public decimal PrecioUnitario { get; set; }
        [Column("cantidad_factura", TypeName = "decimal(12, 5)")]
        public decimal CantidadFactura { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(12, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Column("cantidad_operada", TypeName = "decimal(12, 5)")]
        public decimal CantidadOperada { get; set; }
        [Column("cantidad_devuelta", TypeName = "decimal(12, 5)")]
        public decimal CantidadDevuelta { get; set; }
        [Column("importe", TypeName = "decimal(12, 2)")]
        public decimal Importe { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Required]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("cantidad_cartones")]
        [StringLength(1)]
        public string CantidadCartones { get; set; }
        [Column("mercancia_danada")]
        [StringLength(1)]
        public string MercanciaDanada { get; set; }
        [Column("sin_numero")]
        [StringLength(1)]
        public string SinNumero { get; set; }
        [Column("parte_proveedor")]
        [StringLength(1)]
        public string ParteProveedor { get; set; }
        [Column("observaciones")]
        [StringLength(40)]
        public string Observaciones { get; set; }
        [Column("num_partida", TypeName = "decimal(4, 0)")]
        public decimal? NumPartida { get; set; }
        [Column("subpar_sn")]
        [StringLength(1)]
        public string SubparSn { get; set; }
        [Column("peso_neto", TypeName = "numeric(14, 3)")]
        public decimal? PesoNeto { get; set; }
        [Column("id_pais_vendedor")]
        [StringLength(4)]
        public string IdPaisVendedor { get; set; }
        [Column("sf")]
        [StringLength(2)]
        public string Sf { get; set; }
        [Column("pl")]
        [StringLength(2)]
        public string Pl { get; set; }
        [Column("supp")]
        [StringLength(4)]
        public string Supp { get; set; }
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("id_unidad_comercial")]
        [StringLength(5)]
        public string IdUnidadComercial { get; set; }
        [Column("valor_agregado", TypeName = "decimal(12, 6)")]
        public decimal? ValorAgregado { get; set; }
        [Column("fraccion_eei")]
        [StringLength(10)]
        public string FraccionEei { get; set; }
        [Column("license")]
        [StringLength(15)]
        public string License { get; set; }
        [Column("eccn")]
        [StringLength(15)]
        public string Eccn { get; set; }
        [Column("descripcion_eei")]
        [StringLength(250)]
        public string DescripcionEei { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal? NumeroSecuencial { get; set; }
        [Column("numero_secuencial_pedimento", TypeName = "numeric(5, 0)")]
        public decimal? NumeroSecuencialPedimento { get; set; }
        [Column("skid")]
        [StringLength(20)]
        public string Skid { get; set; }
        [Column("dist_order_number")]
        [StringLength(8)]
        public string DistOrderNumber { get; set; }
        [Column("dealer_order_number")]
        [StringLength(8)]
        public string DealerOrderNumber { get; set; }
        [Column("case_number")]
        [StringLength(8)]
        public string CaseNumber { get; set; }
        [Column("nafta_ind")]
        [StringLength(1)]
        public string NaftaInd { get; set; }
        [Column("unidad_eei")]
        [StringLength(10)]
        public string UnidadEei { get; set; }
        [Column("CANTIDAD_EEI", TypeName = "decimal(18, 5)")]
        public decimal? CantidadEei { get; set; }
        [Column("producto_aux")]
        [StringLength(50)]
        public string ProductoAux { get; set; }
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(80)]
        public string Modelo { get; set; }
        [Column("serie")]
        [StringLength(25)]
        public string Serie { get; set; }
        [Column("pallet_number")]
        [StringLength(25)]
        public string PalletNumber { get; set; }
        [Column("carton_number")]
        [StringLength(25)]
        public string CartonNumber { get; set; }
    }
}
