using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr_pedimento_americano")]
    public partial class FdodaQrPedimentoAmericano
    {
        [Key]
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Key]
        [Column("valor_pedimento_americano")]
        [StringLength(20)]
        public string ValorPedimentoAmericano { get; set; }
        [Column("tipo_pedimento_americano")]
        [StringLength(2)]
        public string TipoPedimentoAmericano { get; set; }
    }
}
