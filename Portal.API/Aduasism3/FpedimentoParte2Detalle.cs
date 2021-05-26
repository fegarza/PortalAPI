using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_parte2_detalle")]
    [Index(nameof(Rowguid), Name = "index_385436447", IsUnique = true)]
    public partial class FpedimentoParte2Detalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("id_numero_vehiculo")]
        [StringLength(15)]
        public string IdNumeroVehiculo { get; set; }
        [Key]
        [Column("partida", TypeName = "numeric(3, 0)")]
        public decimal Partida { get; set; }
        [Required]
        [Column("unidad_tarifa")]
        [StringLength(3)]
        public string UnidadTarifa { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(15, 3)")]
        public decimal CantidadTarifa { get; set; }
        [Required]
        [Column("unidad_comercial")]
        [StringLength(3)]
        public string UnidadComercial { get; set; }
        [Column("cantidad_comercial", TypeName = "numeric(15, 3)")]
        public decimal CantidadComercial { get; set; }
        [Required]
        [Column("descripcion_fraccion1")]
        [StringLength(250)]
        public string DescripcionFraccion1 { get; set; }
        [Column("descripcion_fraccion2", TypeName = "text")]
        public string DescripcionFraccion2 { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
