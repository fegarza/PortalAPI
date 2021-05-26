using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_proveedor_comprador")]
    public partial class TpProveedorComprador
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_proveedor")]
        public short IdProveedor { get; set; }
        [Column("identificador_fiscal")]
        [StringLength(17)]
        public string IdentificadorFiscal { get; set; }
        [Column("proveedor_comprador")]
        [StringLength(120)]
        public string ProveedorComprador { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero_exterior")]
        [StringLength(10)]
        public string NumeroExterior { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("ciudad_municipio")]
        [StringLength(80)]
        public string CiudadMunicipio { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("pais_direccion")]
        [StringLength(250)]
        public string PaisDireccion { get; set; }
        [Column("moneda")]
        [StringLength(3)]
        public string Moneda { get; set; }
        [Column("valor_moneda_extranjera", TypeName = "decimal(12, 2)")]
        public decimal? ValorMonedaExtranjera { get; set; }
        [Column("valor_dolares", TypeName = "decimal(12, 2)")]
        public decimal? ValorDolares { get; set; }
        [Column("pais")]
        [StringLength(3)]
        public string Pais { get; set; }
    }
}
