using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbitacora_tarifa")]
    public partial class FbitacoraTarifa
    {
        [Key]
        public int Actualizacion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Fecha { get; set; }
        [Column(TypeName = "text")]
        public string Descripcion { get; set; }
        [StringLength(500)]
        public string Ejemplo { get; set; }
    }
}
