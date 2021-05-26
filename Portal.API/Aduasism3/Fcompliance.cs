using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcompliance")]
    public partial class Fcompliance
    {
        [Key]
        [Column("id_comp")]
        [StringLength(3)]
        public string IdComp { get; set; }
        [Column("seccion")]
        [StringLength(50)]
        public string Seccion { get; set; }
    }
}
