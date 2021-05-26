using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_determinacion_contribuciones_articulo303")]
    public partial class TpDeterminacionContribucionesArticulo303
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_determinacion")]
        public short IdDeterminacion { get; set; }
        [Column("pais_destino")]
        [StringLength(3)]
        public string PaisDestino { get; set; }
        [Column("fraccion_arancelaria")]
        [StringLength(8)]
        public string FraccionArancelaria { get; set; }
        [Column("secuencia_fraccion_arancelaria")]
        public int? SecuenciaFraccionArancelaria { get; set; }
        [Column("valor_mercancia_no_originaria", TypeName = "decimal(12, 2)")]
        public decimal? ValorMercanciaNoOriginaria { get; set; }
        [Column("monto_igi", TypeName = "decimal(12, 2)")]
        public decimal? MontoIgi { get; set; }
        [Column("total_arancel_eu_canada", TypeName = "decimal(12, 2)")]
        public decimal? TotalArancelEuCanada { get; set; }
        [Column("moneda")]
        [StringLength(3)]
        public string Moneda { get; set; }
        [Column("monto_exento", TypeName = "decimal(12, 2)")]
        public decimal? MontoExento { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
    }
}
