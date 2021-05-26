using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgtrafico_observacion")]
    [Index(nameof(Rowguid), Name = "index_1162487220", IsUnique = true)]
    public partial class FgtraficoObservacion
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Column("observacion")]
        [StringLength(120)]
        public string Observacion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
