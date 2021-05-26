using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_detalle")]
    [Index(nameof(SecuencialFactura), Name = "IDX_DBA24_oc_factura_detalle_secuencial_factura")]
    [Index(nameof(IdFactura), Name = "Indx_oc_factura_detalle_id_factura")]
    [Index(nameof(SecuencialFactura), Name = "Indx_oc_factura_detalle_secuencial_factura")]
    public partial class OcFacturaDetalle
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
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("secuencial_factura")]
        public int SecuencialFactura { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("posicion")]
        public int? Posicion { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("id_unidad_medida")]
        [StringLength(5)]
        public string IdUnidadMedida { get; set; }
        [Column("proyecto")]
        [StringLength(15)]
        public string Proyecto { get; set; }
        [Column("precio_unitario", TypeName = "decimal(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Column("cantidad_ordenada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOrdenada { get; set; }
        [Column("cantidad_facturada", TypeName = "decimal(18, 5)")]
        public decimal CantidadFacturada { get; set; }
        [Column("cantidad_recibida", TypeName = "decimal(18, 5)")]
        public decimal CantidadRecibida { get; set; }
        [Column("cantidad_devuelta", TypeName = "decimal(18, 5)")]
        public decimal CantidadDevuelta { get; set; }
        [Column("cantidad_operada", TypeName = "decimal(18, 5)")]
        public decimal CantidadOperada { get; set; }
        [Column("danado")]
        public bool Danado { get; set; }
        [Column("cantidad_danada", TypeName = "decimal(18, 5)")]
        public decimal CantidadDanada { get; set; }
        [Column("importe_total", TypeName = "decimal(18, 5)")]
        public decimal ImporteTotal { get; set; }
        [Required]
        [Column("id_pais_vendedor")]
        [StringLength(3)]
        public string IdPaisVendedor { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Column("certificado_origen")]
        public bool CertificadoOrigen { get; set; }
        [Column("confirma_co")]
        public bool ConfirmaCo { get; set; }
        [Column("situacion_fact_detalle")]
        public short SituacionFactDetalle { get; set; }
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
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("status_operacion")]
        public short StatusOperacion { get; set; }
        [Column("valor_agregado", TypeName = "decimal(18, 5)")]
        public decimal? ValorAgregado { get; set; }
        [Column("orden_partida")]
        public int OrdenPartida { get; set; }
        [Column("lote")]
        [StringLength(50)]
        public string Lote { get; set; }
        [Column("cantidad_packing", TypeName = "decimal(18, 5)")]
        public decimal? CantidadPacking { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column("sin_cantidad_recibida")]
        public bool? SinCantidadRecibida { get; set; }
        [Column("vinculacion")]
        [StringLength(50)]
        public string Vinculacion { get; set; }
        [Column("mv")]
        [StringLength(50)]
        public string Mv { get; set; }
        [Column("observaciones")]
        [StringLength(300)]
        public string Observaciones { get; set; }
        [Column("complemento_preferencia")]
        [StringLength(20)]
        public string ComplementoPreferencia { get; set; }
        [Column("preferencia")]
        [StringLength(3)]
        public string Preferencia { get; set; }
        [Column("peso_bruto", TypeName = "decimal(14, 3)")]
        public decimal? PesoBruto { get; set; }
    }
}
