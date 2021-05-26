using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconsecutivo_x_bodega_embarque")]
    public partial class FconsecutivoXBodegaEmbarque
    {
        [Key]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("id_prefijo")]
        [StringLength(3)]
        public string IdPrefijo { get; set; }
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal? Consecutivo { get; set; }
    }
}
