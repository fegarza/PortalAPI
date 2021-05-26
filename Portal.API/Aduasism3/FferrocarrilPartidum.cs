using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferrocarril_partida")]
    [Index(nameof(Rowguid), Name = "index_1583344705", IsUnique = true)]
    public partial class FferrocarrilPartidum
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Key]
        [Column("numero_sec", TypeName = "numeric(4, 0)")]
        public decimal NumeroSec { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("cantidad_prod", TypeName = "numeric(12, 5)")]
        public decimal CantidadProd { get; set; }
        [Column("importe", TypeName = "numeric(12, 2)")]
        public decimal? Importe { get; set; }
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Column("descripcion_factura")]
        [StringLength(70)]
        public string DescripcionFactura { get; set; }
        [Column("descripcion_clasificacion")]
        [StringLength(250)]
        public string DescripcionClasificacion { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(14, 3)")]
        public decimal? CantidadComercial { get; set; }
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(14, 3)")]
        public decimal? CantidadTarifa { get; set; }
        [Column("cve_unidad_tarifa")]
        [StringLength(2)]
        public string CveUnidadTarifa { get; set; }
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Column("iva", TypeName = "numeric(4, 2)")]
        public decimal? Iva { get; set; }
        [Column("advalorem", TypeName = "numeric(6, 3)")]
        public decimal? Advalorem { get; set; }
        [Column("iva_fpago")]
        [StringLength(2)]
        public string IvaFpago { get; set; }
        [Column("adval_fpago")]
        [StringLength(2)]
        public string AdvalFpago { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
    }
}
