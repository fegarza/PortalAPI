using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("status_trafico")]
    public partial class StatusTrafico
    {
        [Key]
        [Column("status_trafico")]
        public short StatusTrafico1 { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
