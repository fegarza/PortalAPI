using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_producto_proveedor")]
    public partial class OcProductoProveedor
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
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal? PrecioUnitario { get; set; }
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 5)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 5)")]
        public decimal PesoKilos { get; set; }
        [Column("sku")]
        [StringLength(50)]
        public string Sku { get; set; }
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
        [Column("prio_1")]
        [StringLength(1)]
        public string Prio1 { get; set; }
        [Column("prio_2")]
        [StringLength(1)]
        public string Prio2 { get; set; }
        [Column("prio_3")]
        [StringLength(1)]
        public string Prio3 { get; set; }
        [Column("complemento")]
        [StringLength(20)]
        public string Complemento { get; set; }
    }
}
