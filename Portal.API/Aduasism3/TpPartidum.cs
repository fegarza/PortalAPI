using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_partida")]
    public partial class TpPartidum
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
        [Column("fraccion_arancelaria")]
        [StringLength(8)]
        public string FraccionArancelaria { get; set; }
        [Column("subdivision_fraccion")]
        [StringLength(3)]
        public string SubdivisionFraccion { get; set; }
        [Column("descripcion_mercancia")]
        [StringLength(250)]
        public string DescripcionMercancia { get; set; }
        [Column("unidad_medida_tarifa")]
        [StringLength(3)]
        public string UnidadMedidaTarifa { get; set; }
        [Column("cantidad_unidad_medida_tarifa", TypeName = "decimal(12, 6)")]
        public decimal? CantidadUnidadMedidaTarifa { get; set; }
        [Column("unidad_medida_comercial")]
        [StringLength(3)]
        public string UnidadMedidaComercial { get; set; }
        [Column("cantidad_unidad_medida_comercial", TypeName = "decimal(12, 3)")]
        public decimal? CantidadUnidadMedidaComercial { get; set; }
        [Column("precio_unitario", TypeName = "decimal(12, 6)")]
        public decimal? PrecioUnitario { get; set; }
        [Column("valor_comercial", TypeName = "decimal(12, 0)")]
        public decimal? ValorComercial { get; set; }
        [Column("valor_aduana", TypeName = "decimal(12, 2)")]
        public decimal? ValorAduana { get; set; }
        [Column("valor_dolares", TypeName = "decimal(12, 2)")]
        public decimal? ValorDolares { get; set; }
        [Column("valor_agregado", TypeName = "decimal(12, 0)")]
        public decimal? ValorAgregado { get; set; }
        [Column("codigo_producto")]
        [StringLength(20)]
        public string CodigoProducto { get; set; }
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(80)]
        public string Modelo { get; set; }
        [Column("metodo_valoracion")]
        [StringLength(250)]
        public string MetodoValoracion { get; set; }
        [Column("vinculacion")]
        [StringLength(250)]
        public string Vinculacion { get; set; }
        [Column("pais_origen_destino")]
        [StringLength(3)]
        public string PaisOrigenDestino { get; set; }
        [Column("pais_vendedor_comprador")]
        [StringLength(3)]
        public string PaisVendedorComprador { get; set; }
    }
}
