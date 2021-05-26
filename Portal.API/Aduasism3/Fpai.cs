using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpais")]
    [Index(nameof(Rowguid), Name = "index_1796917473", IsUnique = true)]
    public partial class Fpai
    {
        public Fpai()
        {
            Festados = new HashSet<Festado>();
        }

        [Key]
        [Column("id_pais")]
        [StringLength(4)]
        public string IdPais { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("desc_breve")]
        [StringLength(10)]
        public string DescBreve { get; set; }
        [Required]
        [Column("cve_pais")]
        [StringLength(3)]
        public string CvePais { get; set; }
        [Required]
        [Column("moneda")]
        [StringLength(20)]
        public string Moneda { get; set; }
        [Column("factor_moneda", TypeName = "numeric(10, 8)")]
        public decimal FactorMoneda { get; set; }
        [Column("code")]
        [StringLength(3)]
        public string Code { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(Festado.IdPaisNavigation))]
        public virtual ICollection<Festado> Festados { get; set; }
    }
}
