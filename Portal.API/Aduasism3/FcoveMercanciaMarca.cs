using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove_mercancia_marca")]
    public partial class FcoveMercanciaMarca
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
        [Column("sec_mer_mar", TypeName = "numeric(4, 0)")]
        public decimal SecMerMar { get; set; }
        [Key]
        [Column("num_mercancia", TypeName = "numeric(18, 0)")]
        public decimal NumMercancia { get; set; }
        [Column("marca")]
        [StringLength(100)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("sub_modelo")]
        [StringLength(50)]
        public string SubModelo { get; set; }
        [Column("numero_serie")]
        [StringLength(100)]
        public string NumeroSerie { get; set; }
    }
}
