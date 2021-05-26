using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_cuenta")]
    public partial class FtipoCuentum
    {
        [Key]
        [Column("tipo_cuenta")]
        [StringLength(1)]
        public string TipoCuenta { get; set; }
        [Column("descripcion")]
        [StringLength(200)]
        public string Descripcion { get; set; }
    }
}
