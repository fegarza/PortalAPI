using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcoved_catalogo")]
    public partial class FcovedCatalogo
    {
        [Key]
        [Column("id_documento")]
        [StringLength(3)]
        public string IdDocumento { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
