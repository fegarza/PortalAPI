using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_operacion")]
    public partial class FdespachoOperacion
    {
        [Key]
        [Column("numero_bl")]
        [StringLength(25)]
        public string NumeroBl { get; set; }
        [Key]
        [Column("numero_operacion")]
        [StringLength(14)]
        public string NumeroOperacion { get; set; }
        [Column("movimiento")]
        [StringLength(1)]
        public string Movimiento { get; set; }
    }
}
