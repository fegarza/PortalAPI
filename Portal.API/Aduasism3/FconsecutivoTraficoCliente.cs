using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fconsecutivo_trafico_cliente")]
    public partial class FconsecutivoTraficoCliente
    {
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_prefijo")]
        [StringLength(3)]
        public string IdPrefijo { get; set; }
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal? Consecutivo { get; set; }
        [Column("grupo", TypeName = "numeric(18, 0)")]
        public decimal? Grupo { get; set; }
    }
}
