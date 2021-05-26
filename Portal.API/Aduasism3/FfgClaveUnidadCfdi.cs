using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_claveUnidadCFDI")]
    public partial class FfgClaveUnidadCfdi
    {
        [Key]
        [Column("id_claveUnidadCFDI")]
        public int IdClaveUnidadCfdi { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Required]
        [Column("c_ClaveUnidad")]
        [StringLength(3)]
        public string CClaveUnidad { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("fechaInicioVigencia", TypeName = "datetime")]
        public DateTime? FechaInicioVigencia { get; set; }
        [Column("fechaFinVigencia", TypeName = "datetime")]
        public DateTime? FechaFinVigencia { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
    }
}
