using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("FDORDEN_COMPRA")]
    public partial class FdordenCompra
    {
        [Key]
        [Column("ID_CLIENTE")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_orden_compra")]
        [StringLength(15)]
        public string IdOrdenCompra { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_producto")]
        [StringLength(16)]
        public string IdProducto { get; set; }
        [Column("CANTIDAD_ORDENADA", TypeName = "numeric(12, 5)")]
        public decimal CantidadOrdenada { get; set; }
        [Column("cantidad_x_recibir", TypeName = "numeric(12, 5)")]
        public decimal CantidadXRecibir { get; set; }
        [Column("importe", TypeName = "numeric(11, 2)")]
        public decimal Importe { get; set; }
    }
}
