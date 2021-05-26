using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wdigitalizacion_parametro")]
    public partial class WdigitalizacionParametro
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("parametro")]
        [StringLength(25)]
        public string Parametro { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcionEn")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
    }
}
