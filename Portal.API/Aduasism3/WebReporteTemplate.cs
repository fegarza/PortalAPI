using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("web_reporte_template")]
    public partial class WebReporteTemplate
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("reporte")]
        public short Reporte { get; set; }
        [Key]
        [Column("secuencial")]
        public short Secuencial { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Required]
        [Column("header")]
        public bool? Header { get; set; }
        [Required]
        [Column("id_tipo_template")]
        [StringLength(1)]
        public string IdTipoTemplate { get; set; }
        [Column("usuario_template")]
        [StringLength(6)]
        public string UsuarioTemplate { get; set; }
        [Column("rol_template")]
        public short? RolTemplate { get; set; }
        [Column("cliente_template")]
        [StringLength(6)]
        public string ClienteTemplate { get; set; }
        [Column("grupo_template")]
        [StringLength(6)]
        public string GrupoTemplate { get; set; }
        [Column("observaciones")]
        [StringLength(500)]
        public string Observaciones { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("fila_inicio")]
        public int? FilaInicio { get; set; }
    }
}
