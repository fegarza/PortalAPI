using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_tipo_pedimento_regimen")]
    [Index(nameof(Rowguid), Name = "index_206623779", IsUnique = true)]
    public partial class FrelTipoPedimentoRegiman
    {
        [Key]
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey("CveTipoOperacion,IdRegimen")]
        [InverseProperty("FrelTipoPedimentoRegimen")]
        public virtual Fregiman Fregiman { get; set; }
        [ForeignKey(nameof(IdTipoPedimento))]
        [InverseProperty(nameof(FtipoPedimento.FrelTipoPedimentoRegimen))]
        public virtual FtipoPedimento IdTipoPedimentoNavigation { get; set; }
    }
}
