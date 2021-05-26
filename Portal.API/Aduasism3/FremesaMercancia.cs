using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fremesa_mercancias")]
    public partial class FremesaMercancia
    {
        [Key]
        [Column("id_Referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Column("descripcion_comercial")]
        [StringLength(250)]
        public string DescripcionComercial { get; set; }
        [Column("valor_dolares", TypeName = "numeric(12, 4)")]
        public decimal? ValorDolares { get; set; }
        [Column("bultos", TypeName = "numeric(4, 0)")]
        public decimal? Bultos { get; set; }
    }
}
