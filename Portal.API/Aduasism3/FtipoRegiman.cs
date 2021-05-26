using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_regimen")]
    [Index(nameof(Rowguid), Name = "index_834102012", IsUnique = true)]
    public partial class FtipoRegiman
    {
        public FtipoRegiman()
        {
            Fregimen = new HashSet<Fregiman>();
        }

        [Key]
        [Column("id_tipo_regimen")]
        [StringLength(2)]
        public string IdTipoRegimen { get; set; }
        [Required]
        [Column("descrip_tipo_regimen")]
        [StringLength(50)]
        public string DescripTipoRegimen { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(Fregiman.IdTipoRegimenNavigation))]
        public virtual ICollection<Fregiman> Fregimen { get; set; }
    }
}
