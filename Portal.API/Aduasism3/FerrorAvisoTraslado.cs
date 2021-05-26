using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_aviso_traslado")]
    public partial class FerrorAvisoTraslado
    {
        [Key]
        [Column("id_error")]
        [StringLength(4)]
        public string IdError { get; set; }
        [Key]
        [Column("tipo_error")]
        [StringLength(1)]
        public string TipoError { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
