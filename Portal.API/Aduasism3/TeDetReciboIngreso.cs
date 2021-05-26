using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_det_recibo_ingreso")]
    public partial class TeDetReciboIngreso
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(6, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Key]
        [Column("tipo_docto", TypeName = "numeric(3, 0)")]
        public decimal TipoDocto { get; set; }
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Required]
        [Column("num_cuenta")]
        [StringLength(14)]
        public string NumCuenta { get; set; }
        [Key]
        [Column("num_docto", TypeName = "numeric(6, 0)")]
        public decimal NumDocto { get; set; }
        [Column("valor_docto_cobro", TypeName = "numeric(16, 4)")]
        public decimal ValorDoctoCobro { get; set; }
    }
}
