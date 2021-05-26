using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_configuracion")]
    public partial class TpConfiguracion
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("aduana")]
        [StringLength(3)]
        public string Aduana { get; set; }
        [Key]
        [Column("patente")]
        public int Patente { get; set; }
        [Key]
        [Column("pedimento")]
        public int Pedimento { get; set; }
        [Column("no_operacion", TypeName = "decimal(18, 0)")]
        public decimal? NoOperacion { get; set; }
        [Column("no_control")]
        public int? NoControl { get; set; }
        [Column("partidas")]
        public bool? Partidas { get; set; }
        [Column("cantidad_partidas")]
        public int? CantidadPartidas { get; set; }
        [Column("referencia")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Column("rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? Rectificacion { get; set; }
        [Column("traspaso")]
        public bool? Traspaso { get; set; }
        [Column("referencia_corresponsal")]
        [StringLength(10)]
        public string ReferenciaCorresponsal { get; set; }
    }
}
