using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_frac_adva")]
    [Index(nameof(Rowguid), Name = "index_2002106173", IsUnique = true)]
    public partial class FrelFracAdva
    {
        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Column("porc_advalorem", TypeName = "numeric(6, 3)")]
        public decimal PorcAdvalorem { get; set; }
        [Column("porc_preferencial", TypeName = "numeric(5, 2)")]
        public decimal PorcPreferencial { get; set; }
        [Column("fecha_diario_oficial", TypeName = "datetime")]
        public DateTime FechaDiarioOficial { get; set; }
        [Column("fecha_vigencia", TypeName = "datetime")]
        public DateTime FechaVigencia { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey("CveTipoOpn,IdFraccionMex")]
        [InverseProperty("FrelFracAdvas")]
        public virtual FfraccionMex FfraccionMex { get; set; }
        [ForeignKey(nameof(IdTipoAdvalorem))]
        [InverseProperty(nameof(FtipoAdvalorem.FrelFracAdvas))]
        public virtual FtipoAdvalorem IdTipoAdvaloremNavigation { get; set; }
    }
}
