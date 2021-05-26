using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fembarque_issues")]
    public partial class FembarqueIssue
    {
        [Key]
        [Column("id_issue")]
        [StringLength(10)]
        public string IdIssue { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
