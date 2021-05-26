using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffacturas_consolidadas")]
    public partial class FfacturasConsolidada
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(15, 3)")]
        public decimal CantidadComercial { get; set; }
        [Column("valor_comercial", TypeName = "numeric(14, 2)")]
        public decimal? ValorComercial { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [Column("moneda_facturacion")]
        [StringLength(3)]
        public string MonedaFacturacion { get; set; }
        [Column("factor", TypeName = "numeric(10, 8)")]
        public decimal? Factor { get; set; }
        [Column("identificador")]
        [StringLength(15)]
        public string Identificador { get; set; }
        [Column("cant_bultos", TypeName = "numeric(8, 0)")]
        public decimal? CantBultos { get; set; }
        [Column("peso_neto", TypeName = "numeric(14, 3)")]
        public decimal? PesoNeto { get; set; }
        [Column("cve_tipo_guia")]
        [StringLength(1)]
        public string CveTipoGuia { get; set; }
        [Column("guia")]
        [StringLength(20)]
        public string Guia { get; set; }
        [Column("guia_house")]
        [StringLength(20)]
        public string GuiaHouse { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("usuario_autoriza")]
        [StringLength(10)]
        public string UsuarioAutoriza { get; set; }
        [Column("fecha_impresion", TypeName = "datetime")]
        public DateTime? FechaImpresion { get; set; }
        [Column("valor_dolares", TypeName = "numeric(12, 6)")]
        public decimal? ValorDolares { get; set; }
        [Column("planta")]
        [StringLength(6)]
        public string Planta { get; set; }
        [Column("tipo_factura_asociar")]
        public int? TipoFacturaAsociar { get; set; }
        [Column("factura_aux")]
        [StringLength(36)]
        public string FacturaAux { get; set; }
        [Column("no_pallet")]
        [StringLength(18)]
        public string NoPallet { get; set; }
    }
}
