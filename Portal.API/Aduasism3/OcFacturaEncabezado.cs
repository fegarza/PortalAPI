using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_factura_encabezado")]
    public partial class OcFacturaEncabezado
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
        [Column("fecha_factura", TypeName = "date")]
        public DateTime FechaFactura { get; set; }
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
        [Required]
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("valor_factura", TypeName = "decimal(12, 2)")]
        public decimal ValorFactura { get; set; }
        [Column("importe_comercial", TypeName = "decimal(12, 2)")]
        public decimal ImporteComercial { get; set; }
        [Column("importe_comercial_oc", TypeName = "decimal(12, 2)")]
        public decimal ImporteComercialOc { get; set; }
        [Column("importe_flete", TypeName = "decimal(12, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("importe_seguro", TypeName = "decimal(12, 2)")]
        public decimal ImporteSeguro { get; set; }
        [Column("importe_embalaje", TypeName = "decimal(12, 2)")]
        public decimal ImporteEmbalaje { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 2)")]
        public decimal ImporteOtros { get; set; }
        [Required]
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("orden_noautorizada")]
        public bool OrdenNoautorizada { get; set; }
        [Column("autoriza_orden")]
        [StringLength(15)]
        public string AutorizaOrden { get; set; }
        [Column("serie_orden_compra")]
        [StringLength(2)]
        public string SerieOrdenCompra { get; set; }
        [Column("compania")]
        [StringLength(3)]
        public string Compania { get; set; }
        [Column("division_orden_compra")]
        [StringLength(2)]
        public string DivisionOrdenCompra { get; set; }
        [Column("unidad_negocio")]
        [StringLength(4)]
        public string UnidadNegocio { get; set; }
        [Column("grupo_producto")]
        [StringLength(15)]
        public string GrupoProducto { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("status_factura")]
        public short StatusFactura { get; set; }
        [Column("situacion_factura")]
        public short SituacionFactura { get; set; }
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
        [Column("envio")]
        [StringLength(15)]
        public string Envio { get; set; }
        [Column("consolidada")]
        public bool Consolidada { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("status_operacion")]
        public short StatusOperacion { get; set; }
        [Column("virtual")]
        public bool Virtual { get; set; }
        [Column("valida_packing")]
        public bool ValidaPacking { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(18, 6)")]
        public decimal? TipoCambio { get; set; }
        [Column("id_destinatario")]
        [StringLength(10)]
        public string IdDestinatario { get; set; }
        [Column("factor_comercial", TypeName = "decimal(10, 8)")]
        public decimal? FactorComercial { get; set; }
        [Column("folio")]
        [StringLength(50)]
        public string Folio { get; set; }
        [Column("agrupar_packing")]
        public bool? AgruparPacking { get; set; }
        [Column("subdivision")]
        public short? Subdivision { get; set; }
        [Column("fecha_llegada", TypeName = "datetime")]
        public DateTime? FechaLlegada { get; set; }
        [Column("proveedor_certifica")]
        [StringLength(50)]
        public string ProveedorCertifica { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("id_moneda_valor_agregado")]
        [StringLength(4)]
        public string IdMonedaValorAgregado { get; set; }
    }
}
