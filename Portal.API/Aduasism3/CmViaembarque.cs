using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("cm_viaembarque")]
    public partial class CmViaembarque
    {
        [Key]
        [Column("cveviaembarque", TypeName = "decimal(3, 0)")]
        public decimal Cveviaembarque { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
