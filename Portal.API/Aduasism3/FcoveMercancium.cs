using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_mercancia")]
    public partial class FcoveMercancium
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("identificador", TypeName = "numeric(9, 0)")]
        public decimal Identificador { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(4, 0)")]
        public decimal Secuencial { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("cve_unidad_com")]
        [StringLength(30)]
        public string CveUnidadCom { get; set; }
        [Column("cantidad_com", TypeName = "decimal(15, 3)")]
        public decimal? CantidadCom { get; set; }
        [Column("valor_unitario", TypeName = "decimal(16, 6)")]
        public decimal? ValorUnitario { get; set; }
        [Column("valor_total", TypeName = "decimal(16, 6)")]
        public decimal? ValorTotal { get; set; }
        [Column("valor_dolares", TypeName = "decimal(16, 4)")]
        public decimal? ValorDolares { get; set; }
        [Column("tipo_moneda")]
        [StringLength(3)]
        public string TipoMoneda { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
    }
}
