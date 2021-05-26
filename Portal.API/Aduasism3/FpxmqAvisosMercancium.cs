using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpxmq_avisos_mercancia")]
    public partial class FpxmqAvisosMercancium
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("unidad_medida")]
        public short? UnidadMedida { get; set; }
        [Column("cantidad", TypeName = "decimal(14, 3)")]
        public decimal? Cantidad { get; set; }
        [Column("valor_dolares", TypeName = "decimal(14, 3)")]
        public decimal? ValorDolares { get; set; }
    }
}
