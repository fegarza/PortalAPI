using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_estado_pac")]
    public partial class FfgEstadoPac
    {
        [Column("Id_Estado")]
        [StringLength(5)]
        public string IdEstado { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
