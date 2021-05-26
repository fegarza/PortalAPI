using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("log_movs")]
    public partial class LogMov
    {
        [Column("tipo_elemento")]
        public int? TipoElemento { get; set; }
        [Column("valor_actual", TypeName = "decimal(12, 4)")]
        public decimal? ValorActual { get; set; }
        [Column("valor_anterior", TypeName = "decimal(12, 4)")]
        public decimal? ValorAnterior { get; set; }
        [Column("valor_acumulado", TypeName = "decimal(12, 4)")]
        public decimal? ValorAcumulado { get; set; }
        [Column("time", TypeName = "datetime")]
        public DateTime? Time { get; set; }
        [Column("cveconcepto")]
        [StringLength(20)]
        public string Cveconcepto { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("usuarios")]
        [StringLength(10)]
        public string Usuarios { get; set; }
    }
}
