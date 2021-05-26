using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("reporte")]
    public partial class Reporte
    {
        [Key]
        [Column("reporte")]
        public short Reporte1 { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("codigo_iso")]
        [StringLength(30)]
        public string CodigoIso { get; set; }
        [Column("usuario_firma")]
        [StringLength(8)]
        public string UsuarioFirma { get; set; }
        [Required]
        [Column("nombre_archivo")]
        [StringLength(255)]
        public string NombreArchivo { get; set; }
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
        [Column("revisioniso")]
        [StringLength(20)]
        public string Revisioniso { get; set; }
        [Column("para_reporteador")]
        public bool ParaReporteador { get; set; }
    }
}
