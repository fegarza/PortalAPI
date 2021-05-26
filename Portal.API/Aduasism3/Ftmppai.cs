using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftmppais")]
    public partial class Ftmppai
    {
        [Key]
        [Column("saai96")]
        [StringLength(2)]
        public string Saai96 { get; set; }
        [Required]
        [Column("saaim3")]
        [StringLength(3)]
        public string Saaim3 { get; set; }
    }
}
