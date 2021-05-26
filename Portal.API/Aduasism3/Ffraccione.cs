using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffracciones")]
    public partial class Ffraccione
    {
        [Column("fraccion")]
        [StringLength(9)]
        public string Fraccion { get; set; }
    }
}
