using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproveedor_cer_merc_cli")]
    public partial class FproveedorCerMercCli
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("secuencial")]
        public int Secuencial { get; set; }
        [Column("razon_social_prov")]
        [StringLength(50)]
        public string RazonSocialProv { get; set; }
    }
}
