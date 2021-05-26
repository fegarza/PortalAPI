using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdcertificado_origen")]
    public partial class FdcertificadoOrigen
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "decimal(4, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Column("id_fraccion")]
        [StringLength(6)]
        public string IdFraccion { get; set; }
        [Column("descripcion_clasificacion")]
        [StringLength(250)]
        public string DescripcionClasificacion { get; set; }
        [Column("criterion")]
        [StringLength(10)]
        public string Criterion { get; set; }
        [Column("producer")]
        [StringLength(10)]
        public string Producer { get; set; }
        [Column("net_cost")]
        [StringLength(10)]
        public string NetCost { get; set; }
    }
}
