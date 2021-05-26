using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_vehiculo_contenedor")]
    public partial class FrelVehiculoContenedor
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(5, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("id_numero_vehiculo")]
        [StringLength(20)]
        public string IdNumeroVehiculo { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("num_contenedor")]
        [StringLength(12)]
        public string NumContenedor { get; set; }
        [Key]
        [Column("tipo_contenedor")]
        public short TipoContenedor { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
    }
}
