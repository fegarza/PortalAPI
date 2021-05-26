using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_cheques_cobro")]
    public partial class TeChequesCobro
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(6, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cheque_cobro", TypeName = "numeric(10, 0)")]
        public decimal NumChequeCobro { get; set; }
        [Column("importe_cheque_cobro", TypeName = "numeric(16, 4)")]
        public decimal ImporteChequeCobro { get; set; }
    }
}
