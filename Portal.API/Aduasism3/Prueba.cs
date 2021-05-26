using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("prueba")]
    public partial class Prueba
    {
        [Column("id")]
        [StringLength(4)]
        public string Id { get; set; }
    }
}
