using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fautoriza_embarque")]
    public partial class FautorizaEmbarque
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(20)]
        public string IdTrafico { get; set; }
        [Column("rojo_fecha", TypeName = "datetime")]
        public DateTime? RojoFecha { get; set; }
        [Column("rojo_usuario")]
        [StringLength(50)]
        public string RojoUsuario { get; set; }
        [Column("FTZ_fecha", TypeName = "datetime")]
        public DateTime? FtzFecha { get; set; }
        [Column("FTZ_usuario")]
        [StringLength(50)]
        public string FtzUsuario { get; set; }
        [Column("autoriza_fecha", TypeName = "datetime")]
        public DateTime? AutorizaFecha { get; set; }
        [Column("autoriza_usuario")]
        [StringLength(50)]
        public string AutorizaUsuario { get; set; }
        [Column("autoriza_fecha_FTZ", TypeName = "datetime")]
        public DateTime? AutorizaFechaFtz { get; set; }
        [Column("autoriza_usuario_FTZ")]
        [StringLength(50)]
        public string AutorizaUsuarioFtz { get; set; }
    }
}
