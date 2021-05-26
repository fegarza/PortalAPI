using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_banco")]
    [Index(nameof(Rowguid), Name = "index_933578364", IsUnique = true)]
    public partial class FerrorBanco
    {
        [Key]
        [Column("id_error_banco")]
        [StringLength(2)]
        public string IdErrorBanco { get; set; }
        [Required]
        [Column("descricpcion")]
        [StringLength(100)]
        public string Descricpcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
