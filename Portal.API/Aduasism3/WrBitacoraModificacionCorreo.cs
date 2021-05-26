using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_bitacora_modificacion_correos")]
    public partial class WrBitacoraModificacionCorreo
    {
        [Key]
        [Column("id_registro")]
        public int IdRegistro { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_modificacion", TypeName = "datetime")]
        public DateTime FechaModificacion { get; set; }
        [Required]
        [Column("cambio")]
        [StringLength(100)]
        public string Cambio { get; set; }
        [Column("id_configuracion")]
        public int? IdConfiguracion { get; set; }
        [Column("id_cliente")]
        [StringLength(100)]
        public string IdCliente { get; set; }
        [Column("id_reporte")]
        public int? IdReporte { get; set; }
    }
}
