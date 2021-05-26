using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_vehiculo_fotografia_tipo_movimiento")]
    public partial class OcVehiculoFotografiaTipoMovimiento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("id_tipo_movimiento")]
        public short IdTipoMovimiento { get; set; }
        [Column("id_vehiculo_fotografia")]
        public short IdVehiculoFotografia { get; set; }
    }
}
