using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_bitacora")]
    public partial class WrBitacora
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_configuracion")]
        public int IdConfiguracion { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Key]
        [Column("fecha_envio", TypeName = "datetime")]
        public DateTime FechaEnvio { get; set; }
        [Column("fecha_reenvio", TypeName = "datetime")]
        public DateTime? FechaReenvio { get; set; }
        [Column("reenviar")]
        public bool Reenviar { get; set; }
        [Column("parametros")]
        [StringLength(1024)]
        public string Parametros { get; set; }
        [Column("intentos")]
        public int Intentos { get; set; }
        [Column("fecha_reintento", TypeName = "datetime")]
        public DateTime? FechaReintento { get; set; }
    }
}
