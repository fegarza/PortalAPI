using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("feventos_aduana_estado")]
    public partial class FeventosAduanaEstado
    {
        [Key]
        [Column("id_edo")]
        [StringLength(2)]
        public string IdEdo { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
