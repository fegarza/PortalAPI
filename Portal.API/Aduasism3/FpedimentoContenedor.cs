using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_contenedor")]
    [Index(nameof(Rowguid), Name = "index_1460916276", IsUnique = true)]
    public partial class FpedimentoContenedor
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Column("num_contenedor")]
        [StringLength(12)]
        public string NumContenedor { get; set; }
        [Column("tipo_contenedor")]
        public short? TipoContenedor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
