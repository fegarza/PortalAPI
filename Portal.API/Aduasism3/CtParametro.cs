using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ct_parametros")]
    public partial class CtParametro
    {
        [Column("tipo_parametro", TypeName = "decimal(2, 0)")]
        public decimal TipoParametro { get; set; }
        [Required]
        [Column("cve_parametro")]
        [StringLength(20)]
        public string CveParametro { get; set; }
        [Column("valor")]
        [StringLength(70)]
        public string Valor { get; set; }
    }
}
