using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class ViewPedimentoFactura
    {
        [Required]
        [Column("referencia")]
        [StringLength(10)]
        public string Referencia { get; set; }
        [Column("rectificacion", TypeName = "numeric(1, 0)")]
        public decimal Rectificacion { get; set; }
        [Required]
        [Column("factura")]
        [StringLength(15)]
        public string Factura { get; set; }
        [Required]
        [Column("proveedor")]
        [StringLength(6)]
        public string Proveedor { get; set; }
        [Required]
        [Column("proveedorNombre")]
        [StringLength(120)]
        public string ProveedorNombre { get; set; }
        [Column("fechaFactura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Column("tipoFfactura")]
        [StringLength(4)]
        public string TipoFfactura { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numeroExterior")]
        [StringLength(10)]
        public string NumeroExterior { get; set; }
        [Column("numeroInterior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("proveedorCiudad")]
        [StringLength(80)]
        public string ProveedorCiudad { get; set; }
        [Column("proveedorEstado")]
        [StringLength(10)]
        public string ProveedorEstado { get; set; }
        [Column("proveedorIRS")]
        [StringLength(20)]
        public string ProveedorIrs { get; set; }
        [Column("paisOrigen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("entidadFederativa")]
        [StringLength(3)]
        public string EntidadFederativa { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("cantidadConsolidada", TypeName = "numeric(17, 5)")]
        public decimal? CantidadConsolidada { get; set; }
        [Column("claveBulto", TypeName = "numeric(1, 0)")]
        public decimal? ClaveBulto { get; set; }
        [Column("incoterm")]
        [StringLength(20)]
        public string Incoterm { get; set; }
        [Column("cantidadBulto", TypeName = "numeric(5, 0)")]
        public decimal? CantidadBulto { get; set; }
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [Column("valorFactura", TypeName = "numeric(14, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("monedaFactura")]
        [StringLength(3)]
        public string MonedaFactura { get; set; }
        [Column("factorMoneda", TypeName = "numeric(10, 8)")]
        public decimal? FactorMoneda { get; set; }
        [Column("valorDolares", TypeName = "numeric(15, 2)")]
        public decimal? ValorDolares { get; set; }
    }
}
