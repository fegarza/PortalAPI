using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_packing_encabezado")]
    public partial class OcPackingEncabezado
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
        [Column("fecha_packing", TypeName = "date")]
        public DateTime FechaPacking { get; set; }
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
        [Column("serie_orden_compra")]
        [StringLength(2)]
        public string SerieOrdenCompra { get; set; }
        [Column("status_packing")]
        public short StatusPacking { get; set; }
        [Column("status_operacion")]
        public short StatusOperacion { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(8)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("po_mixta")]
        public bool PoMixta { get; set; }
    }
}
