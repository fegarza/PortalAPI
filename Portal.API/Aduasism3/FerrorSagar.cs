using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_sagar")]
    public partial class FerrorSagar
    {
        [Key]
        [Column("id_error_sagar")]
        [StringLength(5)]
        public string IdErrorSagar { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
