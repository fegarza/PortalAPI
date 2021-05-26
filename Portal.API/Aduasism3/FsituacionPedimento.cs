using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsituacion_pedimento")]
    public partial class FsituacionPedimento
    {
        [Key]
        [Column("situacion")]
        public short Situacion { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
