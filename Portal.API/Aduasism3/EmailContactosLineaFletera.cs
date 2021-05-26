using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("email_contactos_linea_fletera")]
    public partial class EmailContactosLineaFletera
    {
        [Key]
        [Column("id_contacto", TypeName = "numeric(18, 0)")]
        public decimal IdContacto { get; set; }
        [Key]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("email")]
        [StringLength(200)]
        public string Email { get; set; }
        [Column("notificacion_embarque")]
        [StringLength(1)]
        public string NotificacionEmbarque { get; set; }
        [Column("notificacion_embarque_op")]
        [StringLength(1)]
        public string NotificacionEmbarqueOp { get; set; }
    }
}
