using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_manvalcarta")]
    public partial class FclientePerfilManvalcartum
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
        [Column("manifestacion_valor")]
        [StringLength(1)]
        public string ManifestacionValor { get; set; }
        [Column("carta_encomenda")]
        [StringLength(1)]
        public string CartaEncomenda { get; set; }
        [Column("fecha_venc_mval", TypeName = "datetime")]
        public DateTime? FechaVencMval { get; set; }
        [Column("fecha_venc_cenc", TypeName = "datetime")]
        public DateTime? FechaVencCenc { get; set; }
        [Column("dias_ant_mval", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntMval { get; set; }
        [Column("dias_ant_cenc", TypeName = "numeric(3, 0)")]
        public decimal? DiasAntCenc { get; set; }
    }
}
