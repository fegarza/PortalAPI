using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class OcViewInventarioProducto
    {
        [Required]
        [StringLength(8)]
        public string Almacen { get; set; }
        [Required]
        [StringLength(40)]
        public string AlmacenNombre { get; set; }
        [Required]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Required]
        [StringLength(120)]
        public string ClienteNombre { get; set; }
        [Required]
        [StringLength(1)]
        public string Operacion { get; set; }
        [Required]
        [StringLength(20)]
        public string TipoOperacion { get; set; }
        [Required]
        [StringLength(10)]
        public string Recibo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaEntrada { get; set; }
        public int? DiasAlmacen { get; set; }
        [Required]
        [StringLength(6)]
        public string Proveedor { get; set; }
        [Required]
        [StringLength(120)]
        public string NombreProveedor { get; set; }
        public short EstatusRecibo { get; set; }
        [Required]
        [StringLength(30)]
        public string EstatusDescripcion { get; set; }
        [StringLength(15)]
        public string Factura { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? ValorFactura { get; set; }
        [StringLength(4)]
        public string Incoterm { get; set; }
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaOrden { get; set; }
        public int? DiasTranscurridos { get; set; }
        public int? Posicion { get; set; }
        [StringLength(2)]
        public string Serie { get; set; }
        [StringLength(3)]
        public string Compania { get; set; }
        [StringLength(2)]
        public string Division { get; set; }
        [StringLength(15)]
        public string GrupoProducto { get; set; }
        [StringLength(4)]
        public string UnidadNegocio { get; set; }
        [StringLength(20)]
        public string NumeroParte { get; set; }
        [Required]
        [Column("DescripcionERP")]
        [StringLength(250)]
        public string DescripcionErp { get; set; }
        [Column(TypeName = "decimal(19, 5)")]
        public decimal? Cantidad { get; set; }
        [Column(TypeName = "decimal(16, 7)")]
        public decimal? PrecioUnitario { get; set; }
        [StringLength(4)]
        public string UnidadMedida { get; set; }
        [StringLength(40)]
        public string UnidadMedidaDescripcion { get; set; }
        [Required]
        [StringLength(6)]
        public string Proyecto { get; set; }
    }
}
