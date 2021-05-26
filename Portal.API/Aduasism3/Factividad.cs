using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("factividad")]
    [Index(nameof(Rowguid), Name = "index_1266103551", IsUnique = true)]
    public partial class Factividad
    {
        public Factividad()
        {
            FrelUsuactDetalles = new HashSet<FrelUsuactDetalle>();
        }

        [Key]
        [Column("id_actividad")]
        [StringLength(6)]
        public string IdActividad { get; set; }
        [Required]
        [Column("id_proceso")]
        [StringLength(2)]
        public string IdProceso { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Column("facturable")]
        [StringLength(1)]
        public string Facturable { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("incrementable")]
        public bool Incrementable { get; set; }
        [Column("id_tipo_incrementable")]
        public short? IdTipoIncrementable { get; set; }
        [Column("activa")]
        public bool Activa { get; set; }

        [ForeignKey(nameof(IdProceso))]
        [InverseProperty(nameof(Fproceso.Factividads))]
        public virtual Fproceso IdProcesoNavigation { get; set; }
        [InverseProperty(nameof(FrelUsuactDetalle.IdActividadNavigation))]
        public virtual ICollection<FrelUsuactDetalle> FrelUsuactDetalles { get; set; }
    }
}
