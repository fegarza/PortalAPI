using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr_contenedor_detalle")]
    public partial class FdodaQrContenedorDetalle
    {
        [Key]
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Key]
        [Column("valor_contenedor")]
        [StringLength(20)]
        public string ValorContenedor { get; set; }
        [Key]
        [Column("valor_candado")]
        [StringLength(20)]
        public string ValorCandado { get; set; }
    }
}
