using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_encargo")]
    [Index(nameof(Rowguid), Name = "index_2029302339", IsUnique = true)]
    public partial class FerrorEncargo
    {
        [Key]
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Error { get; set; }
        [Column("descripcion")]
        [StringLength(200)]
        public string Descripcion { get; set; }
        [Column("tipo_Error", TypeName = "numeric(18, 0)")]
        public decimal? TipoError { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
