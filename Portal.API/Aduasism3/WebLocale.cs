using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("webLocale")]
    public partial class WebLocale
    {
        [Key]
        [Column("locale")]
        [StringLength(2)]
        public string Locale { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(20)]
        public string Descripcion { get; set; }
    }
}
