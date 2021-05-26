using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_perm_reg")]
    [Index(nameof(Rowguid), Name = "index_142623551", IsUnique = true)]
    public partial class FrelPermReg
    {
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Column("cve_opcional", TypeName = "numeric(1, 0)")]
        public decimal CveOpcional { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey("CveTipoOperacion,IdRegimen")]
        [InverseProperty("FrelPermRegs")]
        public virtual Fregiman Fregiman { get; set; }
    }
}
