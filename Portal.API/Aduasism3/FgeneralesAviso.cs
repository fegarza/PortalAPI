using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fgenerales_aviso")]
    public partial class FgeneralesAviso
    {
        [Column("consecutivo_aviso", TypeName = "numeric(3, 0)")]
        public decimal ConsecutivoAviso { get; set; }
        [Required]
        [Column("ruta_in")]
        [StringLength(250)]
        public string RutaIn { get; set; }
        [Required]
        [Column("ruta_out")]
        [StringLength(250)]
        public string RutaOut { get; set; }
    }
}
