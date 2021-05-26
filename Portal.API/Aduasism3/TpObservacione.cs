using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_observaciones")]
    public partial class TpObservacione
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("secuencial")]
        public short Secuencial { get; set; }
        [Column("observaciones")]
        [StringLength(120)]
        public string Observaciones { get; set; }
    }
}
