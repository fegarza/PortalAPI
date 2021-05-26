using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdfactura")]
    [Index(nameof(IdEntrada), Name = "IX_fdfactura")]
    [Index(nameof(IdEntrada), Name = "IX_fdfactura_1")]
    [Index(nameof(Rowguid), Name = "index_1095727006", IsUnique = true)]
    public partial class Fdfactura
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
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
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("precio_unitario", TypeName = "decimal(19, 10)")]
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
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("valor_agregado", TypeName = "decimal(12, 0)")]
        public decimal? ValorAgregado { get; set; }
        [Column("prod_autorizado")]
        [StringLength(1)]
        public string ProdAutorizado { get; set; }
        [Column("lote")]
        [StringLength(50)]
        public string Lote { get; set; }
        [Column("num_det_previo", TypeName = "numeric(18, 0)")]
        public decimal? NumDetPrevio { get; set; }
        [Column("id_previo")]
        [StringLength(50)]
        public string IdPrevio { get; set; }
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(80)]
        public string Modelo { get; set; }
        [Column("serie")]
        [StringLength(25)]
        public string Serie { get; set; }
        [Column("fletes_partida", TypeName = "decimal(12, 2)")]
        public decimal? FletesPartida { get; set; }
        [Column("seguros_partida", TypeName = "decimal(12, 2)")]
        public decimal? SegurosPartida { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Column("fecha_elaboracion", TypeName = "datetime")]
        public DateTime? FechaElaboracion { get; set; }
        [Column("fecha_caducidad", TypeName = "datetime")]
        public DateTime? FechaCaducidad { get; set; }
        [Column("num_packs", TypeName = "decimal(6, 0)")]
        public decimal? NumPacks { get; set; }
        [Column("observaciones_producto")]
        [StringLength(250)]
        public string ObservacionesProducto { get; set; }
        [Column("cf")]
        [StringLength(1)]
        public string Cf { get; set; }
        [Column("cantidad_tarifa", TypeName = "decimal(14, 3)")]
        public decimal? CantidadTarifa { get; set; }
        [Column("id_fraccion_8va")]
        [StringLength(8)]
        public string IdFraccion8va { get; set; }
        [Column("id_proveedor_original")]
        [StringLength(6)]
        public string IdProveedorOriginal { get; set; }
        [Column("prosec")]
        [StringLength(1)]
        public string Prosec { get; set; }
        [Column("immex")]
        [StringLength(1)]
        public string Immex { get; set; }
        [Column("id_externo")]
        public int? IdExterno { get; set; }
        [Column("id_unidad_cliente")]
        [StringLength(20)]
        public string IdUnidadCliente { get; set; }
        [Column("unidad_tarifa")]
        [StringLength(20)]
        public string UnidadTarifa { get; set; }
        [Column("nico")]
        [StringLength(2)]
        public string Nico { get; set; }

        [ForeignKey(nameof(IdUnidadUniversal))]
        [InverseProperty(nameof(FunidadUniversal.Fdfacturas))]
        public virtual FunidadUniversal IdUnidadUniversalNavigation { get; set; }
    }
}
