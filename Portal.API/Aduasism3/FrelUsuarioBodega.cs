using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_usuario_bodega")]
    public partial class FrelUsuarioBodega
    {
        [Key]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Key]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
    }
}
