using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("usac_tipo_operacion")]
    public partial class UsacTipoOperacion
    {
        [Key]
        [Column("clave")]
        [StringLength(1)]
        public string Clave { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
