using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_modulo_documento_cliente")]
    public partial class DigModuloDocumentoCliente
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_digitalizacion")]
        [StringLength(20)]
        public string IdDigitalizacion { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
    }
}
