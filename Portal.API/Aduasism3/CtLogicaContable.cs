using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_logica_contable")]
    public partial class CtLogicaContable
    {
        [Key]
        [Column("logica")]
        public int Logica { get; set; }
        [Required]
        [Column("programa", TypeName = "text")]
        public string Programa { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
    }
}
