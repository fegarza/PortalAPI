using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdig_area")]
    [Index(nameof(Rowguid), Name = "index_821577965", IsUnique = true)]
    public partial class FdigArea
    {
        [Key]
        [Column("caracter")]
        [StringLength(1)]
        public string Caracter { get; set; }
        [Column("valor", TypeName = "numeric(2, 0)")]
        public decimal Valor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
