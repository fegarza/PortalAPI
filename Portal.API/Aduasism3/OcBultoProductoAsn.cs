using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_bulto_producto_asn")]
    public partial class OcBultoProductoAsn
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("asn")]
        [StringLength(15)]
        public string Asn { get; set; }
        [Key]
        [Column("secuencial_bulto")]
        public short SecuencialBulto { get; set; }
        [Key]
        [Column("secuencial_producto")]
        public short SecuencialProducto { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("no_entrega")]
        [StringLength(15)]
        public string NoEntrega { get; set; }
        [Column("no_lote")]
        [StringLength(15)]
        public string NoLote { get; set; }
        [Required]
        [Column("id_producto_cliente")]
        [StringLength(20)]
        public string IdProductoCliente { get; set; }
        [Column("id_producto_proveedor")]
        [StringLength(35)]
        public string IdProductoProveedor { get; set; }
        [Column("cantidad", TypeName = "decimal(18, 5)")]
        public decimal Cantidad { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Required]
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("fraccion_mex")]
        [StringLength(8)]
        public string FraccionMex { get; set; }
        [Column("fraccion_ame")]
        [StringLength(10)]
        public string FraccionAme { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("descripcion_en")]
        [StringLength(250)]
        public string DescripcionEn { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
    }
}
