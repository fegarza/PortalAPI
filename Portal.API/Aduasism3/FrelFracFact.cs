using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_frac_fact")]
    [Index(nameof(Rowguid), Name = "index_702677601", IsUnique = true)]
    public partial class FrelFracFact
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
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "decimal(5, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("partida", TypeName = "decimal(5, 0)")]
        public decimal Partida { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(14, 3)")]
        public decimal? CantidadComercial { get; set; }
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Column("valor_comercial", TypeName = "decimal(14, 2)")]
        public decimal? ValorComercial { get; set; }
        [Column("cant_bultos", TypeName = "numeric(9, 2)")]
        public decimal? CantBultos { get; set; }
        [Column("peso_kgs", TypeName = "numeric(12, 3)")]
        public decimal? PesoKgs { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
