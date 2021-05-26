using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_packing_detalle_factura")]
    public partial class OcPackingDetalleFactura
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
        [StringLength(64)]
        public string IdPacking { get; set; }
        [Key]
        [Column("secuencial_packing")]
        public int SecuencialPacking { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("secuencial_factura")]
        public int SecuencialFactura { get; set; }
        [Column("cantidad_packing_usada", TypeName = "decimal(18, 5)")]
        public decimal? CantidadPackingUsada { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
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
        [Column("cantidad_subdivision", TypeName = "decimal(18, 5)")]
        public decimal? CantidadSubdivision { get; set; }
        [Column("recibo_subdivision")]
        [StringLength(10)]
        public string ReciboSubdivision { get; set; }
        [Column("subdividido")]
        public bool? Subdividido { get; set; }
        [Required]
        [Column("id_recibo_packing")]
        [StringLength(10)]
        public string IdReciboPacking { get; set; }
    }
}
