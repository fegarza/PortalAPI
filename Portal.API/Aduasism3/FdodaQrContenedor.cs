using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr_contenedor")]
    public partial class FdodaQrContenedor
    {
        [Key]
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Key]
        [Column("valor_contenedor")]
        [StringLength(20)]
        public string ValorContenedor { get; set; }
    }
}
