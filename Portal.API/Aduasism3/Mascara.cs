using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("mascaras")]
    public partial class Mascara
    {
        [Key]
        [Column("atributo_name")]
        [StringLength(50)]
        public string AtributoName { get; set; }
        [Required]
        [Column("mascara")]
        [StringLength(50)]
        public string Mascara1 { get; set; }
    }
}
