using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbitacora_archivos_generados")]
    public partial class FbitacoraArchivosGenerado
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("fecha_generacion", TypeName = "datetime")]
        public DateTime FechaGeneracion { get; set; }
        [Column("fecha_firma", TypeName = "datetime")]
        public DateTime? FechaFirma { get; set; }
        [Column("id_usuario_genero")]
        [StringLength(6)]
        public string IdUsuarioGenero { get; set; }
        [Column("id_usuario_firmo")]
        [StringLength(6)]
        public string IdUsuarioFirmo { get; set; }
        [Column("tipo_archivo")]
        [StringLength(1)]
        public string TipoArchivo { get; set; }
        [Column("ruta_archivo")]
        [StringLength(100)]
        public string RutaArchivo { get; set; }
        [Column("firma_shcp")]
        [StringLength(8)]
        public string FirmaShcp { get; set; }
        [Column("firma_banco")]
        [StringLength(10)]
        public string FirmaBanco { get; set; }
    }
}
