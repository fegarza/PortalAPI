using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_parametros")]
    public partial class PrParametro
    {
        [Key]
        [Column("tipo_parametro")]
        [StringLength(20)]
        public string TipoParametro { get; set; }
        [Key]
        [Column("cve_parametro")]
        [StringLength(20)]
        public string CveParametro { get; set; }
        [Required]
        [Column("valor")]
        [StringLength(50)]
        public string Valor { get; set; }
    }
}
