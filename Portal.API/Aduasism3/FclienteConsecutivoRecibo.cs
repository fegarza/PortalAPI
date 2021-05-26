using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fcliente_consecutivo_recibo")]
    public partial class FclienteConsecutivoRecibo
    {
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("prefijo")]
        [StringLength(3)]
        public string Prefijo { get; set; }
        [Column("consecutivo", TypeName = "numeric(7, 0)")]
        public decimal? Consecutivo { get; set; }
    }
}
