using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_consolidacion_factura")]
    public partial class OcConsolidacionFactura
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_consolidacion")]
        [StringLength(10)]
        public string IdConsolidacion { get; set; }
        [Key]
        [Column("secuencial_factura")]
        public int SecuencialFactura { get; set; }
        [Required]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_tipo_operacion")]
        [StringLength(1)]
        public string IdTipoOperacion { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Column("status_factura")]
        public short StatusFactura { get; set; }
        [Column("situacion_factura")]
        public short SituacionFactura { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("valor_factura", TypeName = "decimal(12, 2)")]
        public decimal ValorFactura { get; set; }
        [Column("importe_comercial", TypeName = "decimal(12, 2)")]
        public decimal? ImporteComercial { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kgs", TypeName = "decimal(14, 3)")]
        public decimal PesoKgs { get; set; }
        [Column("importe_flete", TypeName = "decimal(12, 2)")]
        public decimal? ImporteFlete { get; set; }
        [Column("importe_seguro", TypeName = "decimal(12, 2)")]
        public decimal? ImporteSeguro { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 2)")]
        public decimal? ImporteOtros { get; set; }
        [Column("importe_embalaje", TypeName = "decimal(12, 2)")]
        public decimal? ImporteEmbalaje { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Required]
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("factor_comercial", TypeName = "numeric(10, 8)")]
        public decimal? FactorComercial { get; set; }
    }
}
