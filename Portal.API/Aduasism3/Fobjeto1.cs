using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fobjetos")]
    public partial class Fobjeto1
    {
        [Key]
        [Column("id_proceso")]
        [StringLength(2)]
        public string IdProceso { get; set; }
        [Key]
        [Column("id_objeto")]
        [StringLength(10)]
        public string IdObjeto { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("menu")]
        [StringLength(100)]
        public string Menu { get; set; }
    }
}
