using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_detalle_importacion_EU_canada")]
    public partial class TpDetalleImportacionEuCanadum
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_determinacion")]
        public short IdDeterminacion { get; set; }
        [Key]
        [Column("id_detalle")]
        public short IdDetalle { get; set; }
        [Column("unidad_medida")]
        [StringLength(3)]
        public string UnidadMedida { get; set; }
        [Column("cantidad_unidad_medida", TypeName = "decimal(12, 2)")]
        public decimal? CantidadUnidadMedida { get; set; }
        [Column("fraccion_arancelaria")]
        [StringLength(10)]
        public string FraccionArancelaria { get; set; }
        [Column("tasa", TypeName = "decimal(12, 2)")]
        public decimal? Tasa { get; set; }
        [Column("arancel", TypeName = "decimal(12, 2)")]
        public decimal? Arancel { get; set; }
        [Column("moneda")]
        [StringLength(3)]
        public string Moneda { get; set; }
    }
}
