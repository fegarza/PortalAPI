using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffraccion_mex")]
    [Index(nameof(Rowguid), Name = "index_2052918385", IsUnique = true)]
    public partial class FfraccionMex
    {
        public FfraccionMex()
        {
            FcalculoFraccions = new HashSet<FcalculoFraccion>();
            FrelFracAdvas = new HashSet<FrelFracAdva>();
            FrelFracPerms = new HashSet<FrelFracPerm>();
        }

        [Key]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Column("descripcion_fm")]
        [StringLength(500)]
        public string DescripcionFm { get; set; }
        [Required]
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("cve_derogada")]
        [StringLength(1)]
        public string CveDerogada { get; set; }
        [Column("factor_azucar_x_kg", TypeName = "numeric(7, 5)")]
        public decimal? FactorAzucarXKg { get; set; }
        [Column("id_fraccion_ame")]
        [StringLength(12)]
        public string IdFraccionAme { get; set; }
        [Column("precio_estimado")]
        [StringLength(1)]
        public string PrecioEstimado { get; set; }
        [Column("aviso_automatico")]
        [StringLength(1)]
        public string AvisoAutomatico { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("id_fraccion_ant")]
        [StringLength(8)]
        public string IdFraccionAnt { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_usuario_modif")]
        [StringLength(6)]
        public string IdUsuarioModif { get; set; }
        [Column("fecha_modif", TypeName = "datetime")]
        public DateTime? FechaModif { get; set; }
        [Column("haz_mat")]
        [StringLength(1)]
        public string HazMat { get; set; }
        [Column("prod_quimico")]
        [StringLength(1)]
        public string ProdQuimico { get; set; }
        [Column(TypeName = "text")]
        public string Restricciones { get; set; }
        [Column("cuotas", TypeName = "text")]
        public string Cuotas { get; set; }
        [Column("cupos", TypeName = "text")]
        public string Cupos { get; set; }
        [Column("tasa_pe", TypeName = "decimal(12, 2)")]
        public decimal? TasaPe { get; set; }
        [Column("unidad_pe")]
        [StringLength(5)]
        public string UnidadPe { get; set; }

        [ForeignKey(nameof(IdUnidadUniversal))]
        [InverseProperty(nameof(FunidadUniversal.FfraccionMices))]
        public virtual FunidadUniversal IdUnidadUniversalNavigation { get; set; }
        [InverseProperty(nameof(FcalculoFraccion.FfraccionMex))]
        public virtual ICollection<FcalculoFraccion> FcalculoFraccions { get; set; }
        [InverseProperty(nameof(FrelFracAdva.FfraccionMex))]
        public virtual ICollection<FrelFracAdva> FrelFracAdvas { get; set; }
        [InverseProperty(nameof(FrelFracPerm.FfraccionMex))]
        public virtual ICollection<FrelFracPerm> FrelFracPerms { get; set; }
    }
}
