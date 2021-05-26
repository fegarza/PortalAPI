using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cliente_envio_correo")]
    public partial class ClienteEnvioCorreo
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("correo_edocta")]
        [StringLength(1)]
        public string CorreoEdocta { get; set; }
        [Column("ruta_edocta")]
        [StringLength(250)]
        public string RutaEdocta { get; set; }
        [Column("leyenda_edocta", TypeName = "text")]
        public string LeyendaEdocta { get; set; }
        [Column("correo_factame")]
        [StringLength(1)]
        public string CorreoFactame { get; set; }
        [Column("ruta_factame")]
        [StringLength(250)]
        public string RutaFactame { get; set; }
        [Column("leyenda_factame", TypeName = "text")]
        public string LeyendaFactame { get; set; }
        [Column("correo_factmex")]
        [StringLength(1)]
        public string CorreoFactmex { get; set; }
        [Column("ruta_factmex")]
        [StringLength(250)]
        public string RutaFactmex { get; set; }
        [Column("leyenda_factmex", TypeName = "text")]
        public string LeyendaFactmex { get; set; }
    }
}
