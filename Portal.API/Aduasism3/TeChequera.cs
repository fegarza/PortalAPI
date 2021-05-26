using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_chequera")]
    public partial class TeChequera
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Key]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Required]
        [Column("tipo_chequera")]
        [StringLength(1)]
        public string TipoChequera { get; set; }
        [Key]
        [Column("num_chequera", TypeName = "numeric(3, 0)")]
        public decimal NumChequera { get; set; }
        [Column("cheque_inicial", TypeName = "numeric(10, 0)")]
        public decimal ChequeInicial { get; set; }
        [Column("cheque_final", TypeName = "numeric(10, 0)")]
        public decimal ChequeFinal { get; set; }
        [Column("ultimo_cheque_generado", TypeName = "numeric(10, 0)")]
        public decimal UltimoChequeGenerado { get; set; }
        [Column("status_chequera")]
        public int StatusChequera { get; set; }
    }
}
