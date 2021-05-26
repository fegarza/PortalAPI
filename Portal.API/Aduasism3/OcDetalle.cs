using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_detalle")]
    public partial class OcDetalle
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Key]
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Key]
        [Column("posicion")]
        public int Posicion { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Column("proyecto")]
        [StringLength(15)]
        public string Proyecto { get; set; }
        [Column("cantidad_ordenada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOrdenada { get; set; }
        [Column("cantidad_pendiente", TypeName = "decimal(18, 5)")]
        public decimal CantidadPendiente { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Column("tipo_importacion")]
        [StringLength(1)]
        public string TipoImportacion { get; set; }
        [Column("fecha_entrega", TypeName = "date")]
        public DateTime? FechaEntrega { get; set; }
        [Column("fecha_entrega_confirmada", TypeName = "date")]
        public DateTime? FechaEntregaConfirmada { get; set; }
        [Column("fecha_entrega_cambio", TypeName = "date")]
        public DateTime? FechaEntregaCambio { get; set; }
        [Column("fecha_embarque", TypeName = "date")]
        public DateTime? FechaEmbarque { get; set; }
        [Column("status_orden_detalle")]
        public short StatusOrdenDetalle { get; set; }
        [Column("fraccion")]
        [StringLength(8)]
        public string Fraccion { get; set; }
        [Column("descripcion_ERP")]
        [StringLength(250)]
        public string DescripcionErp { get; set; }
        [Column("cantidad_restante", TypeName = "decimal(18, 5)")]
        public decimal CantidadRestante { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("clave_documento")]
        [StringLength(4)]
        public string ClaveDocumento { get; set; }
        [Column("cantidad_previa", TypeName = "decimal(18, 5)")]
        public decimal? CantidadPrevia { get; set; }
    }
}
