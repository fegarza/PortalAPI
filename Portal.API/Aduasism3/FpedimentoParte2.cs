using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_parte2")]
    [Index(nameof(Rowguid), Name = "index_1989582126", IsUnique = true)]
    public partial class FpedimentoParte2
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("id_numero_vehiculo")]
        [StringLength(15)]
        public string IdNumeroVehiculo { get; set; }
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
        [Column("contenedor")]
        [StringLength(100)]
        public string Contenedor { get; set; }
        [Column("sellos")]
        [StringLength(100)]
        public string Sellos { get; set; }
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal? Consecutivo { get; set; }
        [Column("gondola")]
        [StringLength(1)]
        public string Gondola { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("granel")]
        [StringLength(1)]
        public string Granel { get; set; }
        [Column("consecutivo_ag", TypeName = "numeric(5, 0)")]
        public decimal? ConsecutivoAg { get; set; }
        [Column("campo5")]
        [StringLength(13)]
        public string Campo5 { get; set; }
        [Column("tipo_sellos")]
        [StringLength(1)]
        public string TipoSellos { get; set; }
    }
}
