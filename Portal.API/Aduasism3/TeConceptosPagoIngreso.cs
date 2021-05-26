using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_conceptos_pago_ingreso")]
    public partial class TeConceptosPagoIngreso
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("num_recibo_ingreso", TypeName = "numeric(6, 0)")]
        public decimal NumReciboIngreso { get; set; }
        [Column("cve_cpto_ingreso", TypeName = "numeric(3, 0)")]
        public decimal CveCptoIngreso { get; set; }
        [Column("valor_pago", TypeName = "numeric(16, 4)")]
        public decimal ValorPago { get; set; }
        [Key]
        [Column("consecutivo")]
        public int Consecutivo { get; set; }
    }
}
