using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_banco_centralizado")]
    public partial class FerrorBancoCentralizado
    {
        [Key]
        [Column("id_error_banco")]
        [StringLength(4)]
        public string IdErrorBanco { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
