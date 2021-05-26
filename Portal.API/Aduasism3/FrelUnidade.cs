using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_unidades")]
    public partial class FrelUnidade
    {
        [Key]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("cve_unidad_oficial")]
        [StringLength(2)]
        public string CveUnidadOficial { get; set; }
    }
}
