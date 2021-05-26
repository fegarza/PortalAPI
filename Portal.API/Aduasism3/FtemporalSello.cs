using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftemporal_sello")]
    public partial class FtemporalSello
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("numero_vehiculo")]
        [StringLength(15)]
        public string NumeroVehiculo { get; set; }
        [Key]
        [Column("sello")]
        [StringLength(10)]
        public string Sello { get; set; }
        [Column("marca")]
        [StringLength(30)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(8)]
        public string Modelo { get; set; }
    }
}
