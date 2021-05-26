using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webRol_almacen")]
    public partial class WebRolAlmacen
    {
        [Key]
        [Column("idAplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("rol")]
        public short Rol { get; set; }
        [Key]
        [Column("idBodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
    }
}
