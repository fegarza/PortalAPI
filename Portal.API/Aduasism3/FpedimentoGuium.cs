using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_guia")]
    [Index(nameof(Rowguid), Name = "index_1750297295", IsUnique = true)]
    public partial class FpedimentoGuium
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(4, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("cve_tipo_guia")]
        [StringLength(1)]
        public string CveTipoGuia { get; set; }
        [Required]
        [Column("guia")]
        [StringLength(20)]
        public string Guia { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
