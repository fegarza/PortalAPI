using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_copia_simple")]
    public partial class FpedimentoCopiaSimple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("id_numero_vehiculo")]
        [StringLength(20)]
        public string IdNumeroVehiculo { get; set; }
        [Column("sellos")]
        [StringLength(100)]
        public string Sellos { get; set; }
        [Column("granel")]
        [StringLength(1)]
        public string Granel { get; set; }
        [Column("candados")]
        [StringLength(20)]
        public string Candados { get; set; }
        [Column("oficio")]
        [StringLength(30)]
        public string Oficio { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Column("peso", TypeName = "decimal(14, 3)")]
        public decimal? Peso { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("contenedor")]
        [StringLength(13)]
        public string Contenedor { get; set; }
        [Column("bultos")]
        public int? Bultos { get; set; }
        [Column("fecha_oficio", TypeName = "datetime")]
        public DateTime? FechaOficio { get; set; }
        [Column("gafete")]
        [StringLength(1)]
        public string Gafete { get; set; }
    }
}
