using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_leyenda")]
    public partial class FclientePerfilLeyendum
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
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Column("leyenda")]
        [StringLength(255)]
        public string Leyenda { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
    }
}
