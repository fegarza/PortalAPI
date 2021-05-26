using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_columna_parametro")]
    public partial class WrColumnaParametro
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("reporte")]
        public short Reporte { get; set; }
        [Key]
        [Column("parametro")]
        [StringLength(50)]
        public string Parametro { get; set; }
        [Column("requerido")]
        public bool Requerido { get; set; }
        [Column("orden")]
        public short Orden { get; set; }
        [Column("data_type")]
        public short DataType { get; set; }
    }
}
