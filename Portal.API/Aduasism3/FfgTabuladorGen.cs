using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_tabulador_gen")]
    public partial class FfgTabuladorGen
    {
        [Key]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Key]
        [Column("mex_ame")]
        [StringLength(1)]
        public string MexAme { get; set; }
        [Column("id_tabulador_hon")]
        [StringLength(4)]
        public string IdTabuladorHon { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
        [Column("conversion_moneda")]
        [StringLength(1)]
        public string ConversionMoneda { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("porcen_comision", TypeName = "decimal(18, 0)")]
        public decimal? PorcenComision { get; set; }
        [Column("porcen_honorario", TypeName = "decimal(18, 0)")]
        public decimal? PorcenHonorario { get; set; }
        [Column("planta")]
        [StringLength(6)]
        public string Planta { get; set; }
    }
}
