using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("pruebaxd2")]
    public partial class Pruebaxd2
    {
        [Column("id")]
        [StringLength(20)]
        public string Id { get; set; }
    }
}
