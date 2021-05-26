using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_fechas")]
    public partial class TpFecha
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_importador_exp")]
        public short IdImportadorExp { get; set; }
        [Key]
        [Column("secuencial")]
        public short Secuencial { get; set; }
        [Column("fecha", TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [Column("tipo_fecha")]
        public int? TipoFecha { get; set; }
    }
}
