using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_envio_detalle")]
    public partial class OcEnvioDetalle
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("envio")]
        [StringLength(15)]
        public string Envio { get; set; }
        [Key]
        [Column("factura")]
        [StringLength(36)]
        public string Factura { get; set; }
        [Key]
        [Column("secuencial_envio")]
        public short SecuencialEnvio { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("cantidad_embarcada", TypeName = "decimal(18, 5)")]
        public decimal CantidadEmbarcada { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Column("proyecto")]
        [StringLength(15)]
        public string Proyecto { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Column("importe_total", TypeName = "decimal(12, 2)")]
        public decimal ImporteTotal { get; set; }
        [Column("descripcion_producto")]
        [StringLength(250)]
        public string DescripcionProducto { get; set; }
        [Column("descripcion_ERP")]
        [StringLength(250)]
        public string DescripcionErp { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
    }
}
