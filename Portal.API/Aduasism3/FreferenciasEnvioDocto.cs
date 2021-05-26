using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("freferencias_envio_doctos")]
    public partial class FreferenciasEnvioDocto
    {
        [Key]
        [Column("id_envio_doctos")]
        public long IdEnvioDoctos { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_Rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("fecha_envio", TypeName = "datetime")]
        public DateTime? FechaEnvio { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("mensaje")]
        [StringLength(100)]
        public string Mensaje { get; set; }
    }
}
