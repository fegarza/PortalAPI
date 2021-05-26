using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webReporteColumna_personal")]
    public partial class WebReporteColumnaPersonal
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("reporte")]
        public short Reporte { get; set; }
        [Key]
        [Column("consecutivo")]
        public short Consecutivo { get; set; }
        [Key]
        [Column("columna")]
        [StringLength(50)]
        public string Columna { get; set; }
        [Required]
        [Column("columnaEs")]
        [StringLength(50)]
        public string ColumnaEs { get; set; }
        [Required]
        [Column("columnaEn")]
        [StringLength(50)]
        public string ColumnaEn { get; set; }
        [Column("columnaLongitud")]
        public short ColumnaLongitud { get; set; }
        [Column("columnaOrden")]
        public short ColumnaOrden { get; set; }
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
    }
}
