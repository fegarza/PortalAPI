using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_reg_fraccion_per")]
    public partial class FclientePerfilRegFraccionPer
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
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(3)]
        public string IdPermiso { get; set; }
        [Key]
        [Column("numero_permiso")]
        [StringLength(25)]
        public string NumeroPermiso { get; set; }
        [Column("firma_permiso")]
        [StringLength(30)]
        public string FirmaPermiso { get; set; }
    }
}
