using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferrocarril_factura")]
    [Index(nameof(Rowguid), Name = "index_1567344648", IsUnique = true)]
    public partial class FferrocarrilFactura
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("valor_factura", TypeName = "numeric(12, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("fecha_solicitud_factura", TypeName = "datetime")]
        public DateTime? FechaSolicitudFactura { get; set; }
        [Column("fecha_arribo_factura", TypeName = "datetime")]
        public DateTime? FechaArriboFactura { get; set; }
        [Column("pedido")]
        [StringLength(15)]
        public string Pedido { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
    }
}
