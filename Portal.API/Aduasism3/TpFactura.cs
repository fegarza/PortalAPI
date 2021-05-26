using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_factura")]
    public partial class TpFactura
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_factura")]
        public short IdFactura { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("numero")]
        [StringLength(15)]
        public string Numero { get; set; }
        [Column("termino_facturacion")]
        [StringLength(3)]
        public string TerminoFacturacion { get; set; }
        [Column("moneda")]
        [StringLength(3)]
        public string Moneda { get; set; }
        [Column("valor_dolares", TypeName = "decimal(12, 2)")]
        public decimal? ValorDolares { get; set; }
        [Column("valor_moneda_extranjera", TypeName = "decimal(12, 2)")]
        public decimal? ValorMonedaExtranjera { get; set; }
        [Column("identificador_fiscal_proveedor_comprador")]
        [StringLength(17)]
        public string IdentificadorFiscalProveedorComprador { get; set; }
        [Column("proveedor_comprador")]
        [StringLength(120)]
        public string ProveedorComprador { get; set; }
    }
}
