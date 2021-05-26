using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_partidas_informe_industria_automotriz")]
    public partial class TpPartidasInformeIndustriaAutomotriz
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_partidas_informe")]
        public short IdPartidasInforme { get; set; }
        [Column("fraccion")]
        [StringLength(8)]
        public string Fraccion { get; set; }
        [Column("numero_partida")]
        [StringLength(3)]
        public string NumeroPartida { get; set; }
        [Column("valor_comercial", TypeName = "decimal(12, 2)")]
        public decimal? ValorComercial { get; set; }
        [Column("valor_dolares", TypeName = "decimal(12, 2)")]
        public decimal? ValorDolares { get; set; }
        [Column("cantidad_umc", TypeName = "decimal(12, 2)")]
        public decimal? CantidadUmc { get; set; }
        [Column("unidad_medida_comercial")]
        [StringLength(3)]
        public string UnidadMedidaComercial { get; set; }
        [Column("cantidad_umt", TypeName = "decimal(12, 2)")]
        public decimal? CantidadUmt { get; set; }
        [Column("unidad_medida_tarifa")]
        [StringLength(3)]
        public string UnidadMedidaTarifa { get; set; }
        [Column("pais_origen_destino")]
        [StringLength(3)]
        public string PaisOrigenDestino { get; set; }
        [Column("pais_comprador_vendedor")]
        [StringLength(3)]
        public string PaisCompradorVendedor { get; set; }
    }
}
