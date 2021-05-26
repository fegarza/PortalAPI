using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_TipoComprobanteCFDI")]
    public partial class FfgTipoComprobanteCfdi
    {
        [Key]
        [Column("id_TipoComprobanteCFDI")]
        public byte IdTipoComprobanteCfdi { get; set; }
        [Column("fecha_captura", TypeName = "datetime")]
        public DateTime FechaCaptura { get; set; }
        [Required]
        [Column("c_TipoDeComprobante")]
        [StringLength(1)]
        public string CTipoDeComprobante { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("valor_maximo", TypeName = "decimal(14, 2)")]
        public decimal? ValorMaximo { get; set; }
        [Column("valor_maximoNdS", TypeName = "decimal(14, 2)")]
        public decimal? ValorMaximoNdS { get; set; }
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
