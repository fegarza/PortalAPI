using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_recibo_previo")]
    public partial class OcReciboPrevio
    {
        [Required]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Required]
        [Column("usuario_ingreso")]
        [StringLength(32)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(32)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("fecha_finalizacion", TypeName = "datetime")]
        public DateTime? FechaFinalizacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Required]
        [Column("id_tipo_operacion")]
        [StringLength(1)]
        public string IdTipoOperacion { get; set; }
        [Column("posicion")]
        public int? Posicion { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("nuevo_producto")]
        public bool NuevoProducto { get; set; }
        [Key]
        [Column("id_secuencial")]
        public int IdSecuencial { get; set; }
        [Key]
        [Column("estatus_previo")]
        public int EstatusPrevio { get; set; }
        [Column("peso_kilos", TypeName = "decimal(18, 5)")]
        public decimal? PesoKilos { get; set; }
        [Column("peso_libras", TypeName = "decimal(18, 5)")]
        public decimal? PesoLibras { get; set; }
        [Column("pais_origen")]
        [StringLength(2)]
        public string PaisOrigen { get; set; }
        [Key]
        [Column("oc_packing")]
        [StringLength(64)]
        public string OcPacking { get; set; }
        [Column("id_pais")]
        [StringLength(3)]
        public string IdPais { get; set; }
        [Column("fecha_arribo", TypeName = "datetime")]
        public DateTime? FechaArribo { get; set; }
    }
}
