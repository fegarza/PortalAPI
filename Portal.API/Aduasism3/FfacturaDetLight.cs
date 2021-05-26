using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffactura_det_light")]
    public partial class FfacturaDetLight
    {
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
        [Column("cantidad_factura", TypeName = "decimal(18, 5)")]
        public decimal CantidadFactura { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Column("cantidad_operada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOperada { get; set; }
        [Column("cantidad_devuelta", TypeName = "decimal(18, 5)")]
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
        [Column("skid")]
        [StringLength(20)]
        public string Skid { get; set; }
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("id_unidad_comercial")]
        [StringLength(2)]
        public string IdUnidadComercial { get; set; }
        [Column("valor_agregado", TypeName = "decimal(18, 6)")]
        public decimal? ValorAgregado { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("numero_secuencial_pedimento", TypeName = "numeric(5, 1)")]
        public decimal? NumeroSecuencialPedimento { get; set; }
        [Column("id_orden_compra")]
        [StringLength(50)]
        public string IdOrdenCompra { get; set; }
        [Column("descripcion_clasificacion")]
        [StringLength(250)]
        public string DescripcionClasificacion { get; set; }
        [Column("prov_cert_po")]
        [StringLength(50)]
        public string ProvCertPo { get; set; }
        [Column("po")]
        [StringLength(1)]
        public string Po { get; set; }
    }
}
