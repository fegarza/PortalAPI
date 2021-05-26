using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faduasis_complemento1")]
    public partial class FaduasisComplemento1
    {
        [Key]
        [Column("id_comp")]
        [StringLength(255)]
        public string IdComp { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Texto { get; set; }
        [Column("ident")]
        [StringLength(10)]
        public string Ident { get; set; }
        [Key]
        [Column("secuencial")]
        public int Secuencial { get; set; }
    }
}
