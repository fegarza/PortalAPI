using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webReporte")]
    [Index(nameof(IdAplicacion), nameof(NombreReporte), Name = "ix_webReporte_nombre_reporte")]
    public partial class WebReporte
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("reporte")]
        public short Reporte { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Required]
        [Column("nombre_archivo")]
        [StringLength(255)]
        public string NombreArchivo { get; set; }
        [Column("codigo_iso")]
        [StringLength(30)]
        public string CodigoIso { get; set; }
        [Column("revision_iso")]
        [StringLength(20)]
        public string RevisionIso { get; set; }
        [Column("columnas")]
        public bool Columnas { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(8)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(8)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("reporteador")]
        public bool Reporteador { get; set; }
        [Column("notificacion")]
        public bool Notificacion { get; set; }
        [Column("encabezado")]
        [StringLength(250)]
        public string Encabezado { get; set; }
        [Required]
        [Column("header")]
        public bool? Header { get; set; }
        [Column("connection_number")]
        public short? ConnectionNumber { get; set; }
        [Column("dinamico")]
        public bool Dinamico { get; set; }
        [Column("sp_columnas")]
        [StringLength(50)]
        public string SpColumnas { get; set; }
        [Column("sp_datos")]
        [StringLength(50)]
        public string SpDatos { get; set; }
        [Column("visible")]
        public bool? Visible { get; set; }
        [Column("descripcionCliente")]
        [StringLength(80)]
        public string DescripcionCliente { get; set; }
        [Column("nombre_reporte")]
        [StringLength(50)]
        public string NombreReporte { get; set; }
    }
}
