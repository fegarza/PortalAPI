using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproceso")]
    [Index(nameof(Rowguid), Name = "index_66099276", IsUnique = true)]
    public partial class Fproceso
    {
        public Fproceso()
        {
            Factividads = new HashSet<Factividad>();
            FcalculoGenerals = new HashSet<FcalculoGeneral>();
        }

        [Key]
        [Column("id_proceso")]
        [StringLength(2)]
        public string IdProceso { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(15)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [InverseProperty(nameof(Factividad.IdProcesoNavigation))]
        public virtual ICollection<Factividad> Factividads { get; set; }
        [InverseProperty(nameof(FcalculoGeneral.IdProcesoNavigation))]
        public virtual ICollection<FcalculoGeneral> FcalculoGenerals { get; set; }
    }
}
