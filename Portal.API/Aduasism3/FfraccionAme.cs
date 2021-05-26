using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_ame")]
    [Index(nameof(Rowguid), Name = "index_1398296041", IsUnique = true)]
    public partial class FfraccionAme
    {
        [Key]
        [Column("id_fraccion_ame")]
        [StringLength(12)]
        public string IdFraccionAme { get; set; }
        [Required]
        [Column("descripcion_fa")]
        [StringLength(254)]
        public string DescripcionFa { get; set; }
        [Required]
        [Column("digito_checador")]
        [StringLength(1)]
        public string DigitoChecador { get; set; }
        [Required]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("unidad_medida2")]
        [StringLength(5)]
        public string UnidadMedida2 { get; set; }
        [Column("unida_medida2")]
        [StringLength(5)]
        public string UnidaMedida2 { get; set; }
    }
}
