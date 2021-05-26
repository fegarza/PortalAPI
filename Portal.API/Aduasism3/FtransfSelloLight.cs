using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftransf_sello_light")]
    public partial class FtransfSelloLight
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Key]
        [Column("no_secuencial", TypeName = "numeric(3, 0)")]
        public decimal NoSecuencial { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Required]
        [Column("sello")]
        [StringLength(10)]
        public string Sello { get; set; }
        [Column("caaat")]
        [StringLength(6)]
        public string Caaat { get; set; }
        [Column("fecha_emision", TypeName = "datetime")]
        public DateTime? FechaEmision { get; set; }
    }
}
