using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fuser")]
    public partial class Fuser
    {
        [Key]
        [Column("id_user")]
        [StringLength(6)]
        public string IdUser { get; set; }
        [Column("nombre")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [StringLength(1)]
        public string Status { get; set; }
    }
}
