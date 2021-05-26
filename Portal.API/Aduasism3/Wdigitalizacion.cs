using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion")]
    public partial class Wdigitalizacion
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("digitalizacion")]
        public int Digitalizacion { get; set; }
        [Column("documento")]
        public int Documento { get; set; }
        [Required]
        [Column("extencion")]
        [StringLength(4)]
        public string Extencion { get; set; }
    }
}
