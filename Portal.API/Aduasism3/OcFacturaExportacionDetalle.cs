using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_exportacion_detalle")]
    public partial class OcFacturaExportacionDetalle
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
        [Required]
        [Column("id_producto")]
        [StringLength(20)]
        public string IdProducto { get; set; }
        [Required]
        [Column("descripcion_mexicana")]
        [StringLength(250)]
        public string DescripcionMexicana { get; set; }
        [Column("descripcion_americana")]
        [StringLength(250)]
        public string DescripcionAmericana { get; set; }
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
        [Column("fraccion_americana")]
        [StringLength(10)]
        public string FraccionAmericana { get; set; }
        [Required]
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("importe_material", TypeName = "decimal(18, 5)")]
        public decimal ImporteMaterial { get; set; }
        [Column("valor_agregado", TypeName = "decimal(18, 5)")]
        public decimal ValorAgregado { get; set; }
        [Column("mid_code_agente")]
        [StringLength(15)]
        public string MidCodeAgente { get; set; }
        [Column("mid_code_cliente")]
        [StringLength(15)]
        public string MidCodeCliente { get; set; }
        [Column("indicador_nafta")]
        [StringLength(3)]
        public string IndicadorNafta { get; set; }
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
        [Column("nico")]
        [StringLength(2)]
        public string Nico { get; set; }
        [Column("peso_bruto", TypeName = "decimal(14, 3)")]
        public decimal? PesoBruto { get; set; }
        [Column("pais_vendedor")]
        [StringLength(3)]
        public string PaisVendedor { get; set; }
        [Column("preferencia")]
        [StringLength(3)]
        public string Preferencia { get; set; }
    }
}
