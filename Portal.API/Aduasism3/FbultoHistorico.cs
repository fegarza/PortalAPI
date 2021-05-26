using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbulto_historico")]
    [Index(nameof(Rowguid), Name = "index_1575676661", IsUnique = true)]
    public partial class FbultoHistorico
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
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
        [Column("detalle")]
        [StringLength(80)]
        public string Detalle { get; set; }
        [Column("desc_gral")]
        [StringLength(80)]
        public string DescGral { get; set; }
        [Column("danado")]
        [StringLength(1)]
        public string Danado { get; set; }
        [Key]
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Column("tipo_movimiento")]
        [StringLength(1)]
        public string TipoMovimiento { get; set; }
        [Column("lote")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("peso", TypeName = "numeric(14, 3)")]
        public decimal? Peso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey(nameof(IdEntrada))]
        [InverseProperty(nameof(FentradaBodega.FbultoHistoricos))]
        public virtual FentradaBodega IdEntradaNavigation { get; set; }
    }
}
