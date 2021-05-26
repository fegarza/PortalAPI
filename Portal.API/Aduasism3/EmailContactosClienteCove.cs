using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("email_Contactos_cliente_cove")]
    public partial class EmailContactosClienteCove
    {
        [Key]
        [Column("id_contacto", TypeName = "numeric(18, 0)")]
        public decimal IdContacto { get; set; }
        [Key]
        [Column("cliente")]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Column("email")]
        [StringLength(200)]
        public string Email { get; set; }
        [Column("cove_digital")]
        [StringLength(1)]
        public string CoveDigital { get; set; }
        [Column("cove_digital_op")]
        [StringLength(1)]
        public string CoveDigitalOp { get; set; }
    }
}
