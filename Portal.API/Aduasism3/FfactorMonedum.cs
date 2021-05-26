using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffactor_moneda")]
    [Index(nameof(Rowguid), Name = "index_91863394", IsUnique = true)]
    public partial class FfactorMonedum
    {
        [Key]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("moneda_cove")]
        [StringLength(3)]
        public string MonedaCove { get; set; }
    }
}
