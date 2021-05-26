using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_datos_vehiculo")]
    public partial class TpDatosVehiculo
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("partida")]
        public int Partida { get; set; }
        [Key]
        [Column("numero_partida")]
        public int NumeroPartida { get; set; }
        [Key]
        [Column("secuencial_datos")]
        public short SecuencialDatos { get; set; }
        [Column("vin")]
        [StringLength(25)]
        public string Vin { get; set; }
        [Column("kilometraje", TypeName = "decimal(18, 0)")]
        public decimal? Kilometraje { get; set; }
    }
}
