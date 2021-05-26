using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbulto_detalle")]
    [Index(nameof(Rowguid), Name = "index_491148795", IsUnique = true)]
    public partial class FbultoDetalle
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("no_sec_bulto")]
        public int NoSecBulto { get; set; }
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
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("fecha_trafico", TypeName = "datetime")]
        public DateTime? FechaTrafico { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cantidad_danada")]
        public int CantidadDanada { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("cantidad_bg")]
        public int? CantidadBg { get; set; }
        [Column("no_pallet", TypeName = "numeric(16, 0)")]
        public decimal? NoPallet { get; set; }
        [Column("no_pallet_anterior", TypeName = "numeric(16, 0)")]
        public decimal? NoPalletAnterior { get; set; }
        [Column("unidad_desglose")]
        [StringLength(5)]
        public string UnidadDesglose { get; set; }
        [Column("guia")]
        [StringLength(35)]
        public string Guia { get; set; }
        [Column("tipo_mercancia")]
        public short? TipoMercancia { get; set; }

        [ForeignKey(nameof(IdEntrada))]
        [InverseProperty(nameof(FentradaBodega.FbultoDetalles))]
        public virtual FentradaBodega IdEntradaNavigation { get; set; }
        [ForeignKey(nameof(IdUnidad))]
        [InverseProperty(nameof(Funidad.FbultoDetalles))]
        public virtual Funidad IdUnidadNavigation { get; set; }
    }
}
