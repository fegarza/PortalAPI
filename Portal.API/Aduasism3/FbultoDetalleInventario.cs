using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbulto_detalle_inventario")]
    [Index(nameof(Rowguid), Name = "index_2127346643", IsUnique = true)]
    public partial class FbultoDetalleInventario
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("no_sec_rep", TypeName = "numeric(3, 0)")]
        public decimal NoSecRep { get; set; }
        [Key]
        [Column("no_sec_bulto", TypeName = "numeric(3, 0)")]
        public decimal NoSecBulto { get; set; }
        [Required]
        [Column("numeros")]
        [StringLength(15)]
        public string Numeros { get; set; }
        [Column("cantidad", TypeName = "numeric(8, 0)")]
        public decimal Cantidad { get; set; }
        [Required]
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Required]
        [Column("detalle")]
        [StringLength(80)]
        public string Detalle { get; set; }
        [Required]
        [Column("desc_gral")]
        [StringLength(80)]
        public string DescGral { get; set; }
        [Column("danado")]
        [StringLength(1)]
        public string Danado { get; set; }
        [Column("lote")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("peso", TypeName = "numeric(14, 3)")]
        public decimal? Peso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
