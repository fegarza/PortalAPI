using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_encargo_conferido")]
    public partial class FclientePerfilEncargoConferido
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("encargo_conferido")]
        [StringLength(1)]
        public string EncargoConferido { get; set; }
        [Column("fecha_vence_enconf", TypeName = "datetime")]
        public DateTime? FechaVenceEnconf { get; set; }
        [Column("dias_ant_enconf", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntEnconf { get; set; }
    }
}
