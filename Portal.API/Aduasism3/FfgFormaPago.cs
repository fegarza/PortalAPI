using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_forma_pago")]
    public partial class FfgFormaPago
    {
        [Key]
        [Column("id_forma_pago")]
        public int IdFormaPago { get; set; }
        [Required]
        [Column("descripcion_formapago")]
        [StringLength(100)]
        public string DescripcionFormapago { get; set; }
    }
}
