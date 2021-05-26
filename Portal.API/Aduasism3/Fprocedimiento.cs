using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprocedimiento")]
    public partial class Fprocedimiento
    {
        [Key]
        [Column("id_procedimiento")]
        [StringLength(10)]
        public string IdProcedimiento { get; set; }
        [Column("descripcion")]
        [StringLength(35)]
        public string Descripcion { get; set; }
        [Key]
        [Column("id_objeto")]
        [StringLength(10)]
        public string IdObjeto { get; set; }
        [Key]
        [Column("tipo_procedimiento")]
        [StringLength(1)]
        public string TipoProcedimiento { get; set; }
    }
}
