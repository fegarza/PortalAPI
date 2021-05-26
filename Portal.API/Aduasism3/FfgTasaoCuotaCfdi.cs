using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_TasaoCuotaCFDI")]
    public partial class FfgTasaoCuotaCfdi
    {
        [Key]
        [Column("id_TasaoCuotaCFDI")]
        public byte IdTasaoCuotaCfdi { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Column("Rango_Fijo")]
        [StringLength(1)]
        public string RangoFijo { get; set; }
        [Column("valorMinimo", TypeName = "decimal(10, 7)")]
        public decimal? ValorMinimo { get; set; }
        [Column("c_TasaoCuotaValorMaximo", TypeName = "decimal(10, 7)")]
        public decimal? CTasaoCuotaValorMaximo { get; set; }
        [Column("impuesto")]
        [StringLength(50)]
        public string Impuesto { get; set; }
        [Required]
        [Column("c_tipo_factor")]
        [StringLength(50)]
        public string CTipoFactor { get; set; }
        [Required]
        [Column("traslado")]
        [StringLength(1)]
        public string Traslado { get; set; }
        [Required]
        [Column("retencion")]
        [StringLength(1)]
        public string Retencion { get; set; }
        [Column("fechaInicioVigencia", TypeName = "datetime")]
        public DateTime? FechaInicioVigencia { get; set; }
        [Column("fechaFinVigencia", TypeName = "datetime")]
        public DateTime? FechaFinVigencia { get; set; }
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
    }
}
