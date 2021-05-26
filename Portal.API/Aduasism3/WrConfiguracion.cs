using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_configuracion")]
    public partial class WrConfiguracion
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_configuracion")]
        public int IdConfiguracion { get; set; }
        [Column("reporte")]
        public short Reporte { get; set; }
        [Column("id_formato")]
        public int IdFormato { get; set; }
        [Column("id_periodo")]
        public int IdPeriodo { get; set; }
        [Column("dia_mes")]
        public int DiaMes { get; set; }
        [Column("dia_semana")]
        public short DiaSemana { get; set; }
        [Column("hora")]
        public int Hora { get; set; }
        [Column("minuto")]
        public int Minuto { get; set; }
        [Column("asunto_email")]
        [StringLength(100)]
        public string AsuntoEmail { get; set; }
        [Required]
        [Column("locale")]
        [StringLength(2)]
        public string Locale { get; set; }
        [Column("configuracion_activa")]
        public bool ConfiguracionActiva { get; set; }
        [Column("consecutivo")]
        public short? Consecutivo { get; set; }
        [Column("guardar")]
        public bool Guardar { get; set; }
        [Column("id_digitalizacion")]
        [StringLength(20)]
        public string IdDigitalizacion { get; set; }
        [Column("notificar_vacio")]
        public bool NotificarVacio { get; set; }
        [Column("documentos")]
        public bool? Documentos { get; set; }
    }
}
