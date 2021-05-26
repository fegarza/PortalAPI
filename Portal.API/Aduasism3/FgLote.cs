using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fg_lotes")]
    public partial class FgLote
    {
        [Key]
        [Column("LOTE")]
        [StringLength(10)]
        public string Lote { get; set; }
        [Key]
        [Column("TIPO")]
        [StringLength(1)]
        public string Tipo { get; set; }
        [Column("REFERENCIA")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Column("REFERENCIA_NG")]
        [StringLength(10)]
        public string ReferenciaNg { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("CLTE")]
        [StringLength(30)]
        public string Clte { get; set; }
        [Column("CONFIRMADO")]
        [StringLength(1)]
        public string Confirmado { get; set; }
        [Column("ID_CLIENTE")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("CONSIGNATARIO")]
        [StringLength(6)]
        public string Consignatario { get; set; }
    }
}
