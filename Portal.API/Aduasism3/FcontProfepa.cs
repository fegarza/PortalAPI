using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcont_profepa")]
    public partial class FcontProfepa
    {
        [Key]
        [Column("contador_profepa")]
        public int ContadorProfepa { get; set; }
    }
}
