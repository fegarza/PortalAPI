using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcalculo_gastos_ame")]
    public partial class FcalculoGastosAme
    {
        [Key]
        [Column("id_Calculo")]
        [StringLength(6)]
        public string IdCalculo { get; set; }
        [Key]
        [Column("gasto")]
        [StringLength(20)]
        public string Gasto { get; set; }
        [Key]
        [Column("comprobado")]
        [StringLength(1)]
        public string Comprobado { get; set; }
        [Column("valor", TypeName = "numeric(11, 2)")]
        public decimal? Valor { get; set; }
    }
}
