using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("frel_partidas_factura_pedimento")]
    public partial class FrelPartidasFacturaPedimento
    {
        [Required]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Required]
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Column("num_detalle", TypeName = "decimal(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("numero_secuencial_pedimento", TypeName = "numeric(5, 0)")]
        public decimal? NumeroSecuencialPedimento { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
