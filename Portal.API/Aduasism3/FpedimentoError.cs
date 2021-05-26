using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_error")]
    public partial class FpedimentoError
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_val")]
        [StringLength(2)]
        public string IdTipoVal { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(3, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("registro")]
        [StringLength(4)]
        public string Registro { get; set; }
        [Required]
        [Column("tipo")]
        [StringLength(4)]
        public string Tipo { get; set; }
        [Column("error")]
        [StringLength(4)]
        public string Error { get; set; }
        [Column("campo")]
        [StringLength(4)]
        public string Campo { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
