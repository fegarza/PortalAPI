using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_transporte")]
    public partial class FclientePerfilTransporte
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
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("cve_trans_entrada")]
        [StringLength(2)]
        public string CveTransEntrada { get; set; }
        [Column("cve_trans_arribo")]
        [StringLength(2)]
        public string CveTransArribo { get; set; }
        [Column("cve_trans_salida")]
        [StringLength(2)]
        public string CveTransSalida { get; set; }
    }
}
