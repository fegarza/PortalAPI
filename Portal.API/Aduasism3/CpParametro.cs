using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cp_parametros")]
    public partial class CpParametro
    {
        [Key]
        [Column("tipo_parametro", TypeName = "decimal(2, 0)")]
        public decimal TipoParametro { get; set; }
        [Key]
        [Column("cve_parametro")]
        [StringLength(20)]
        public string CveParametro { get; set; }
        [Column("valor")]
        [StringLength(50)]
        public string Valor { get; set; }
    }
}
