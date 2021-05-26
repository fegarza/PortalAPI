using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_regimen")]
    public partial class FclientePerfilRegiman
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("cve_tipo_oper")]
        [StringLength(1)]
        public string CveTipoOper { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("tipo_caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Key]
        [Column("complemento1")]
        [StringLength(30)]
        public string Complemento1 { get; set; }
        [Key]
        [Column("complemento2")]
        [StringLength(30)]
        public string Complemento2 { get; set; }
        [Key]
        [Column("complemento3")]
        [StringLength(30)]
        public string Complemento3 { get; set; }
    }
}
