using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_modulo_doc")]
    public partial class WdigitalizacionModuloDoc
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        public short IdModulo { get; set; }
        [Key]
        [Column("documento")]
        public int Documento { get; set; }
        [Column("digitalizacion")]
        public int Digitalizacion { get; set; }
    }
}
