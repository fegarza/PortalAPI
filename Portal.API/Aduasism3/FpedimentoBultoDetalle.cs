using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_bulto_detalle")]
    [Index(nameof(Rowguid), Name = "index_1570104634", IsUnique = true)]
    public partial class FpedimentoBultoDetalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(3, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("marca")]
        [StringLength(60)]
        public string Marca { get; set; }
        [Required]
        [Column("numeros")]
        [StringLength(15)]
        public string Numeros { get; set; }
        [Column("cantidad", TypeName = "numeric(8, 0)")]
        public decimal Cantidad { get; set; }
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Column("detalle")]
        [StringLength(80)]
        public string Detalle { get; set; }
        [Column("descripcion_mercancia")]
        [StringLength(80)]
        public string DescripcionMercancia { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }

        [ForeignKey("IdReferencia,IdRectificacion")]
        [InverseProperty(nameof(FpedimentoBulto.FpedimentoBultoDetalles))]
        public virtual FpedimentoBulto IdRe { get; set; }
    }
}
