using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffacturas_detalle")]
    public partial class FfacturasDetalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Required]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Required]
        [Column("descripcion_fraccion")]
        [StringLength(250)]
        public string DescripcionFraccion { get; set; }
        [Column("valor_comercial", TypeName = "numeric(12, 2)")]
        public decimal ValorComercial { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(15, 3)")]
        public decimal CantidadComercial { get; set; }
        [Required]
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(15, 3)")]
        public decimal CantidadTarifa { get; set; }
        [Required]
        [Column("cve_unidad_tarifa")]
        [StringLength(2)]
        public string CveUnidadTarifa { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("pais_vendedor")]
        [StringLength(3)]
        public string PaisVendedor { get; set; }
        [Column("advalorem", TypeName = "numeric(10, 5)")]
        public decimal? Advalorem { get; set; }
        [Column("valor_agregado", TypeName = "decimal(12, 2)")]
        public decimal? ValorAgregado { get; set; }
        [Column("marca")]
        [StringLength(80)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(80)]
        public string Modelo { get; set; }
        [Column("serie")]
        [StringLength(80)]
        public string Serie { get; set; }
        [Column("id_vinculacion")]
        [StringLength(1)]
        public string IdVinculacion { get; set; }
        [Column("valoracion")]
        [StringLength(1)]
        public string Valoracion { get; set; }
        [Column("observaciones")]
        [StringLength(120)]
        public string Observaciones { get; set; }
        [Column("cantidad_prod", TypeName = "decimal(18, 5)")]
        public decimal? CantidadProd { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("observacion")]
        [StringLength(120)]
        public string Observacion { get; set; }
    }
}
