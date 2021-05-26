using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdigitalizacion")]
    public partial class Fdigitalizacion
    {
        [Key]
        [Column("digitalizacion")]
        public int Digitalizacion { get; set; }
        [Column("documento")]
        public int Documento { get; set; }
        [Column("tipo_documento")]
        public int TipoDocumento { get; set; }
        [Required]
        [Column("extencion")]
        [StringLength(3)]
        public string Extencion { get; set; }
        [Column("ruta_documento")]
        [StringLength(200)]
        public string RutaDocumento { get; set; }
    }
}
