using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_packing_detalle")]
    public partial class OcPackingDetalle
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
        [Column("id_packing")]
        [StringLength(15)]
        public string IdPacking { get; set; }
        [Key]
        [Column("secuencial_packing")]
        public int SecuencialPacking { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("posicion")]
        public int? Posicion { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Column("cantidad_ordenada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOrdenada { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Column("situacion_fact_detalle")]
        public short SituacionFactDetalle { get; set; }
        [Column("cantidad_operada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOperada { get; set; }
        [Column("status_operacion")]
        public short StatusOperacion { get; set; }
        [Column("cantidad_packing", TypeName = "decimal(18, 5)")]
        public decimal CantidadPacking { get; set; }
        [Column("cantidad_previa", TypeName = "decimal(18, 5)")]
        public decimal? CantidadPrevia { get; set; }
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
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
    }
}
