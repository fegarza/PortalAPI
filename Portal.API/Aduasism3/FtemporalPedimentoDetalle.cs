using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftemporal_pedimento_detalle")]
    public partial class FtemporalPedimentoDetalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Required]
        [Column("id_tipo_advalorem")]
        [StringLength(3)]
        public string IdTipoAdvalorem { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Required]
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Required]
        [Column("cve_unidad_tarifa")]
        [StringLength(2)]
        public string CveUnidadTarifa { get; set; }
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("pais_vendedor")]
        [StringLength(3)]
        public string PaisVendedor { get; set; }
        [Column("iva", TypeName = "numeric(10, 5)")]
        public decimal? Iva { get; set; }
        [Column("advalorem", TypeName = "numeric(10, 5)")]
        public decimal? Advalorem { get; set; }
        [Column("ieps", TypeName = "numeric(10, 5)")]
        public decimal? Ieps { get; set; }
        [Required]
        [Column("uso_edo_mercancia")]
        [StringLength(1)]
        public string UsoEdoMercancia { get; set; }
        [Required]
        [Column("id_vinculacion")]
        [StringLength(1)]
        public string IdVinculacion { get; set; }
        [Required]
        [Column("valoracion")]
        [StringLength(1)]
        public string Valoracion { get; set; }
        [Column("sensible")]
        [StringLength(1)]
        public string Sensible { get; set; }
    }
}
