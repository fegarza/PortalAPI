using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_documento")]
    public partial class WdigitalizacionDocumento
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("documento")]
        public int Documento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcionEn")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Required]
        [Column("extencion")]
        [StringLength(4)]
        public string Extencion { get; set; }
    }
}
