using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_consolidacion_detalle")]
    public partial class OcConsolidacionDetalle
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("id_instruccion")]
        [StringLength(10)]
        public string IdInstruccion { get; set; }
        [Required]
        [Column("id_consolidacion")]
        [StringLength(10)]
        public string IdConsolidacion { get; set; }
        [Column("consolidado")]
        public bool Consolidado { get; set; }
        [Column("fecha_consolidacion", TypeName = "datetime")]
        public DateTime? FechaConsolidacion { get; set; }
        [Column("usuario_consolida")]
        [StringLength(6)]
        public string UsuarioConsolida { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("factor_moneda_usd", TypeName = "decimal(10, 8)")]
        public decimal? FactorMonedaUsd { get; set; }
        [Column("valor_factura_usd", TypeName = "decimal(12, 2)")]
        public decimal? ValorFacturaUsd { get; set; }
        [Column("importe_comercial_usd", TypeName = "decimal(12, 2)")]
        public decimal? ImporteComercialUsd { get; set; }
        [Column("importe_flete_usd", TypeName = "decimal(12, 2)")]
        public decimal? ImporteFleteUsd { get; set; }
        [Column("importe_seguro_usd", TypeName = "decimal(12, 2)")]
        public decimal? ImporteSeguroUsd { get; set; }
        [Column("importe_embalaje_usd", TypeName = "decimal(12, 2)")]
        public decimal? ImporteEmbalajeUsd { get; set; }
        [Column("importe_otros_usd", TypeName = "decimal(12, 2)")]
        public decimal? ImporteOtrosUsd { get; set; }
        [Column("gastos_flete_usd", TypeName = "decimal(12, 2)")]
        public decimal? GastosFleteUsd { get; set; }
        [Column("gastos_seguro_usd", TypeName = "decimal(12, 2)")]
        public decimal? GastosSeguroUsd { get; set; }
        [Column("gastos_embalaje_usd", TypeName = "decimal(12, 2)")]
        public decimal? GastosEmbalajeUsd { get; set; }
        [Column("gastos_otros_usd", TypeName = "decimal(12, 2)")]
        public decimal? GastosOtrosUsd { get; set; }
        [Column("factor_moneda", TypeName = "decimal(10, 8)")]
        public decimal? FactorMoneda { get; set; }
        [Column("valor_factura", TypeName = "decimal(12, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("importe_comercial", TypeName = "decimal(12, 2)")]
        public decimal? ImporteComercial { get; set; }
        [Column("importe_flete", TypeName = "decimal(12, 2)")]
        public decimal? ImporteFlete { get; set; }
        [Column("importe_seguro", TypeName = "decimal(12, 2)")]
        public decimal? ImporteSeguro { get; set; }
        [Column("importe_embalaje", TypeName = "decimal(12, 2)")]
        public decimal? ImporteEmbalaje { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 2)")]
        public decimal? ImporteOtros { get; set; }
        [Column("gastos_flete", TypeName = "decimal(12, 2)")]
        public decimal? GastosFlete { get; set; }
        [Column("gastos_seguro", TypeName = "decimal(12, 2)")]
        public decimal? GastosSeguro { get; set; }
        [Column("gastos_embalaje", TypeName = "decimal(12, 2)")]
        public decimal? GastosEmbalaje { get; set; }
        [Column("gastos_otros", TypeName = "decimal(12, 2)")]
        public decimal? GastosOtros { get; set; }
    }
}
