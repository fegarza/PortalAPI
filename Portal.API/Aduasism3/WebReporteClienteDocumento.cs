using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webReporteClienteDocumento")]
    public partial class WebReporteClienteDocumento
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("reporte")]
        public short Reporte { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion1 { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
    }
}
