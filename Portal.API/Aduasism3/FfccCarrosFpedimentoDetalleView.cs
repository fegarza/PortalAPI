using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class FfccCarrosFpedimentoDetalleView
    {
        [Required]
        [Column("ID_REFERENCIA")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("ID_RECTIFICACION", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("ID_TIPO_VEHICULO")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("NUMERO_VEHICULO")]
        [StringLength(15)]
        public string NumeroVehiculo { get; set; }
    }
}
