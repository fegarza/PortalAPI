using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fanexo10_referencia")]
    public partial class Fanexo10Referencium
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Column("id_usuario_autorizacion")]
        [StringLength(6)]
        public string IdUsuarioAutorizacion { get; set; }
        [Column("fecha_autorizacion", TypeName = "datetime")]
        public DateTime? FechaAutorizacion { get; set; }
        [Column("descripcion_autorizacion")]
        [StringLength(250)]
        public string DescripcionAutorizacion { get; set; }
    }
}
