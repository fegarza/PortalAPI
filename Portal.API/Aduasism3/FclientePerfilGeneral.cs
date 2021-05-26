using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_perfil_general")]
    public partial class FclientePerfilGeneral
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("cve_tipo_oper")]
        [StringLength(1)]
        public string CveTipoOper { get; set; }
        [Column("valor_dlls_fac", TypeName = "numeric(11, 2)")]
        public decimal? ValorDllsFac { get; set; }
    }
}
