using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_producto_cliente_unidad_aux")]
    public partial class OcProductoClienteUnidadAux
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("unidad_sistema")]
        [StringLength(25)]
        public string UnidadSistema { get; set; }
        [Column("unidad_vastera")]
        [StringLength(25)]
        public string UnidadVastera { get; set; }
        [Column("factor_vastera", TypeName = "decimal(25, 15)")]
        public decimal? FactorVastera { get; set; }
        [Column("unidad_Factura")]
        [StringLength(25)]
        public string UnidadFactura { get; set; }
        [Column("factor_factura", TypeName = "decimal(25, 15)")]
        public decimal? FactorFactura { get; set; }
    }
}
