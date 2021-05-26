using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fbulto_traf_deta")]
    [Index(nameof(Rowguid), Name = "index_1371151930", IsUnique = true)]
    public partial class FbultoTrafDetum
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("no_secuencial")]
        [StringLength(3)]
        public string NoSecuencial { get; set; }
        [Required]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
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
        [Column("desc_mcia")]
        [StringLength(80)]
        public string DescMcia { get; set; }
        [Column("no_sec_ent", TypeName = "numeric(5, 0)")]
        public decimal? NoSecEnt { get; set; }
        [Column("lote")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("no_pallet")]
        public int? NoPallet { get; set; }
        [Column("tipo_mercancia")]
        public short? TipoMercancia { get; set; }
        [Column("peso", TypeName = "numeric(14, 3)")]
        public decimal? Peso { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(8)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(8)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }

        [ForeignKey(nameof(IdTrafico))]
        [InverseProperty(nameof(FbultoTraf.FbultoTrafDeta))]
        public virtual FbultoTraf IdTraficoNavigation { get; set; }
        [ForeignKey(nameof(IdUnidad))]
        [InverseProperty(nameof(Funidad.FbultoTrafDeta))]
        public virtual Funidad IdUnidadNavigation { get; set; }
    }
}
