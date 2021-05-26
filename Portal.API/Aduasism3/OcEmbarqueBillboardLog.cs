using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque_billboard_logs")]
    public partial class OcEmbarqueBillboardLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("accion")]
        [StringLength(130)]
        public string Accion { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(7)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
    }
}
