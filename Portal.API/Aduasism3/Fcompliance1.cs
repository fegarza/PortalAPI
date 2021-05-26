using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fcompliance$")]
    public partial class Fcompliance1
    {
        [Column("id_comp")]
        [StringLength(255)]
        public string IdComp { get; set; }
        [Column("seccion")]
        [StringLength(255)]
        public string Seccion { get; set; }
    }
}
