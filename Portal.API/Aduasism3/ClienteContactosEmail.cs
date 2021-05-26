using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cliente_contactos_email")]
    public partial class ClienteContactosEmail
    {
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("email_contacto_cliente")]
        [StringLength(100)]
        public string EmailContactoCliente { get; set; }
        [Column("envio_edocta")]
        [StringLength(1)]
        public string EnvioEdocta { get; set; }
        [Column("envio_factame")]
        [StringLength(1)]
        public string EnvioFactame { get; set; }
        [Column("envio_factmex")]
        [StringLength(1)]
        public string EnvioFactmex { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("envio_pago")]
        [StringLength(1)]
        public string EnvioPago { get; set; }
    }
}
