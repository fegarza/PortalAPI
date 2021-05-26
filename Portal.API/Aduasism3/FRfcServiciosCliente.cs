using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("f_rfc_servicios_cliente")]
    public partial class FRfcServiciosCliente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Key]
        [Column("razon_social")]
        [StringLength(120)]
        public string RazonSocial { get; set; }
        [Key]
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Key]
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Key]
        [Column("c_default")]
        [StringLength(2)]
        public string CDefault { get; set; }
    }
}
