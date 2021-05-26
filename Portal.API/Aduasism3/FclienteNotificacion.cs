using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_notificacion")]
    public partial class FclienteNotificacion
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("asunto")]
        [StringLength(255)]
        public string Asunto { get; set; }
        [Column("mensaje")]
        [StringLength(255)]
        public string Mensaje { get; set; }
        [Column("adjunto")]
        [StringLength(1)]
        public string Adjunto { get; set; }
    }
}
