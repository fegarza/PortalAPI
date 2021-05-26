using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_carta_encomienda")]
    public partial class FclientePerfilCartaEncomiendum
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("cve_tipo_op")]
        [StringLength(1)]
        public string CveTipoOp { get; set; }
        [Key]
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("carta_encomienda")]
        [StringLength(1)]
        public string CartaEncomienda { get; set; }
        [Column("fecha_vence_cenc", TypeName = "datetime")]
        public DateTime? FechaVenceCenc { get; set; }
        [Column("dias_ant_cenc", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntCenc { get; set; }
    }
}
