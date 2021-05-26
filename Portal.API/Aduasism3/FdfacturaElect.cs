using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdfactura_elect")]
    public partial class FdfacturaElect
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
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Required]
        [Column("id_orden_compra")]
        [StringLength(15)]
        public string IdOrdenCompra { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("descripcionp")]
        [StringLength(30)]
        public string Descripcionp { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Column("cantidad_factura", TypeName = "decimal(18, 5)")]
        public decimal CantidadFactura { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
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
        [Column("observaciones")]
        [StringLength(250)]
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
        [Column("valor_agregado", TypeName = "decimal(12, 2)")]
        public decimal? ValorAgregado { get; set; }
        [Column("descripcionpc")]
        [StringLength(200)]
        public string Descripcionpc { get; set; }
        [Column("id_fraccion")]
        [StringLength(15)]
        public string IdFraccion { get; set; }
        [Column("id_fraccion_ame")]
        [StringLength(15)]
        public string IdFraccionAme { get; set; }
        [Column("pais")]
        [StringLength(3)]
        public string Pais { get; set; }
        [Column("pais_destino")]
        [StringLength(3)]
        public string PaisDestino { get; set; }
        [Column("fletes_partida", TypeName = "decimal(12, 2)")]
        public decimal? FletesPartida { get; set; }
        [Column("seguros_partida", TypeName = "decimal(12, 2)")]
        public decimal? SegurosPartida { get; set; }

        [ForeignKey(nameof(IdUnidadUniversal))]
        [InverseProperty(nameof(FunidadUniversal.FdfacturaElects))]
        public virtual FunidadUniversal IdUnidadUniversalNavigation { get; set; }
    }
}
