using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fentrada_contenedores")]
    public partial class FentradaContenedore
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("contenedores")]
        [StringLength(20)]
        public string Contenedores { get; set; }
    }
}
