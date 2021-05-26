using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fobservaciones")]
    [Index(nameof(Rowguid), Name = "index_1730157259", IsUnique = true)]
    public partial class Fobservacione
    {
        [Key]
        [Column("leyenda")]
        [StringLength(25)]
        public string Leyenda { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumSecuencial { get; set; }
        [Key]
        [Column("tipo_leyenda")]
        [StringLength(1)]
        public string TipoLeyenda { get; set; }
        [Column("observacion")]
        [StringLength(120)]
        public string Observacion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
