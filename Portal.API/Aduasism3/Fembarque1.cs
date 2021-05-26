using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fembarques")]
    [Index(nameof(Rowguid), Name = "index_1630628852", IsUnique = true)]
    public partial class Fembarque1
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime FechaCruce { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("talon")]
        [StringLength(15)]
        public string Talon { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdLineaFletera))]
        [InverseProperty(nameof(FlineaFletera.Fembarque1s))]
        public virtual FlineaFletera IdLineaFleteraNavigation { get; set; }
        [ForeignKey(nameof(IdTipoVehiculo))]
        [InverseProperty(nameof(FtipoVehic.Fembarque1s))]
        public virtual FtipoVehic IdTipoVehiculoNavigation { get; set; }
    }
}
