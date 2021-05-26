using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_consecutivo")]
    public partial class FclienteConsecutivo
    {
        [Key]
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
