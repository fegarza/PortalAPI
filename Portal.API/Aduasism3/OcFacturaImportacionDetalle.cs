using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_importacion_detalle")]
    public partial class OcFacturaImportacionDetalle
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("secuencial_factura")]
        public int SecuencialFactura { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("descripcion_mexicana")]
        [StringLength(250)]
        public string DescripcionMexicana { get; set; }
        [Column("cantidad_facturada", TypeName = "decimal(18, 5)")]
        public decimal CantidadFacturada { get; set; }
        [Column("cantidad_operada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOperada { get; set; }
        [Required]
        [Column("unidad_comercial")]
        [StringLength(5)]
        public string UnidadComercial { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Column("importe_total", TypeName = "decimal(18, 5)")]
        public decimal ImporteTotal { get; set; }
        [Column("fraccion_americana")]
        [StringLength(10)]
        public string FraccionAmericana { get; set; }
        [Column("descripcion_americana")]
        [StringLength(250)]
        public string DescripcionAmericana { get; set; }
        [Column("importe_material", TypeName = "decimal(18, 5)")]
        public decimal? ImporteMaterial { get; set; }
        [Column("cantidad_tarifa", TypeName = "decimal(18, 5)")]
        public decimal? CantidadTarifa { get; set; }
        [Column("unidad_tarifa")]
        [StringLength(4)]
        public string UnidadTarifa { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal? PesoKilos { get; set; }
        [Column("fraccion_mexicana")]
        [StringLength(8)]
        public string FraccionMexicana { get; set; }
        [Column("permiso_regla8va")]
        [StringLength(15)]
        public string PermisoRegla8va { get; set; }
        [Column("regla8va_numero")]
        [StringLength(8)]
        public string Regla8vaNumero { get; set; }
        [Column("permiso_tlcan")]
        [StringLength(15)]
        public string PermisoTlcan { get; set; }
        [Required]
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Required]
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("posicion")]
        public int? Posicion { get; set; }
        [Column("nico")]
        [StringLength(2)]
        public string Nico { get; set; }
    }
}
