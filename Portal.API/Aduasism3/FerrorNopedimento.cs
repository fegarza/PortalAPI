using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_nopedimento")]
    public partial class FerrorNopedimento
    {
        [Key]
        [Column("id_error")]
        [StringLength(3)]
        public string IdError { get; set; }
        [Required]
        [Column("descricpcion")]
        [StringLength(255)]
        public string Descricpcion { get; set; }
    }
}
