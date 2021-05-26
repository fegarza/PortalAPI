using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_archivo_bitacora")]
    public partial class DigArchivoBitacora
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(100)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("secuencial")]
        public short Secuencial { get; set; }
        [Key]
        [Column("fecha_modificacion", TypeName = "datetime")]
        public DateTime FechaModificacion { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Required]
        [Column("movimiento")]
        [StringLength(50)]
        public string Movimiento { get; set; }
    }
}
