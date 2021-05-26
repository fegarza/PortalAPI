using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fobjeto")]
    public partial class Fobjeto
    {
        [Key]
        [Column("id_objeto")]
        [StringLength(10)]
        public string IdObjeto { get; set; }
        [Column("descripcion")]
        [StringLength(35)]
        public string Descripcion { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(35)]
        public string Nombre { get; set; }
    }
}
