using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_vehiculo_fotografia_tipo_vehiculo")]
    public partial class OcVehiculoFotografiaTipoVehiculo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("id_vehiculo_fotografia")]
        public short IdVehiculoFotografia { get; set; }
    }
}
