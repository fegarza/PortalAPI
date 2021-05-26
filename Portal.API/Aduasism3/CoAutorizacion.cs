using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("co_autorizacion")]
    public partial class CoAutorizacion
    {
        [Key]
        [Column("tipo_autoriza", TypeName = "numeric(2, 0)")]
        public decimal TipoAutoriza { get; set; }
        [Key]
        [Column("num_empleado", TypeName = "numeric(9, 0)")]
        public decimal NumEmpleado { get; set; }
        [Column("password")]
        [StringLength(20)]
        public string Password { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
