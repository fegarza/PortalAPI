using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdetalle_shipper")]
    [Index(nameof(Rowguid), Name = "index_757577737", IsUnique = true)]
    public partial class FdetalleShipper
    {
        [Key]
        [Column("id_shipper")]
        [StringLength(8)]
        public string IdShipper { get; set; }
        [Key]
        [Column("id_fraccion_ame")]
        [StringLength(12)]
        public string IdFraccionAme { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal? Cantidad { get; set; }
        [Column("cve_domestic_foreign")]
        [StringLength(1)]
        public string CveDomesticForeign { get; set; }
        [Column("digito")]
        [StringLength(1)]
        public string Digito { get; set; }
        [Column("peso", TypeName = "numeric(14, 3)")]
        public decimal? Peso { get; set; }
        [Column("importe", TypeName = "numeric(12, 2)")]
        public decimal? Importe { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
