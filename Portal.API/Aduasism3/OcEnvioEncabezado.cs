using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_envio_encabezado")]
    public partial class OcEnvioEncabezado
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("envio")]
        [StringLength(15)]
        public string Envio { get; set; }
        [Key]
        [Column("factura")]
        [StringLength(36)]
        public string Factura { get; set; }
        [Column("fecha_factura", TypeName = "date")]
        public DateTime FechaFactura { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("fecha_envio", TypeName = "date")]
        public DateTime FechaEnvio { get; set; }
        [Column("serie_orden_compra")]
        [StringLength(2)]
        public string SerieOrdenCompra { get; set; }
        [Column("status_envio")]
        public short StatusEnvio { get; set; }
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
    }
}
