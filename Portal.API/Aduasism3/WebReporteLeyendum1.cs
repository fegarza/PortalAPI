using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webReporteLeyenda")]
    public partial class WebReporteLeyendum1
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
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Key]
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Key]
        [Column("seccion")]
        [StringLength(2)]
        public string Seccion { get; set; }
        [Required]
        [Column("leyenda")]
        public string Leyenda { get; set; }
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
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
    }
}
