using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_frac_perm")]
    [Index(nameof(Rowguid), Name = "index_2130106629", IsUnique = true)]
    public partial class FrelFracPerm
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
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Column("cve_opcional", TypeName = "numeric(1, 0)")]
        public decimal CveOpcional { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey("CveTipoOpn,IdFraccionMex")]
        [InverseProperty("FrelFracPerms")]
        public virtual FfraccionMex FfraccionMex { get; set; }
    }
}
