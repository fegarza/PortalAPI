using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprevio_det")]
    public partial class FprevioDet
    {
        [Key]
        [Column("id_previo")]
        [StringLength(15)]
        public string IdPrevio { get; set; }
        [Key]
        [Column("num_detalle", TypeName = "decimal(4, 0)")]
        public decimal NumDetalle { get; set; }
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
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal? PrecioUnitario { get; set; }
        [Column("cantidad_previo", TypeName = "decimal(18, 5)")]
        public decimal CantidadPrevio { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Column("cantidad_operada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOperada { get; set; }
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
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("num_partida", TypeName = "decimal(4, 0)")]
        public decimal? NumPartida { get; set; }
        [Column("peso_neto", TypeName = "numeric(14, 3)")]
        public decimal? PesoNeto { get; set; }
        [Column("id_pais_vendedor")]
        [StringLength(4)]
        public string IdPaisVendedor { get; set; }
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(80)]
        public string Modelo { get; set; }
        [Column("serie")]
        [StringLength(25)]
        public string Serie { get; set; }
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Column("num_detalle_factura", TypeName = "decimal(4, 0)")]
        public decimal? NumDetalleFactura { get; set; }
    }
}
