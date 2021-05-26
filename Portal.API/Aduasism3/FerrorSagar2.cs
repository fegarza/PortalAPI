using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ferror_sagar2")]
    [Index(nameof(Rowguid), Name = "index_2107206607", IsUnique = true)]
    public partial class FerrorSagar2
    {
        [Key]
        [Column("id_tipo")]
        [StringLength(1)]
        public string IdTipo { get; set; }
        [Key]
        [Column("codigo")]
        [StringLength(2)]
        public string Codigo { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
