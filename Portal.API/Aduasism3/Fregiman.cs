using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fregimen")]
    [Index(nameof(Rowguid), Name = "index_1666104976", IsUnique = true)]
    public partial class Fregiman
    {
        public Fregiman()
        {
            FrelImpRegPagos = new HashSet<FrelImpRegPago>();
            FrelPermRegs = new HashSet<FrelPermReg>();
            FrelTipoPedimentoRegimen = new HashSet<FrelTipoPedimentoRegiman>();
        }

        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Required]
        [Column("descripcion_reg")]
        [StringLength(50)]
        public string DescripcionReg { get; set; }
        [Required]
        [Column("id_tipo_regimen")]
        [StringLength(2)]
        public string IdTipoRegimen { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("al_millar", TypeName = "numeric(4, 2)")]
        public decimal AlMillar { get; set; }
        [Column("meses_plazo", TypeName = "numeric(4, 0)")]
        public decimal MesesPlazo { get; set; }
        [Required]
        [Column("cve_calculo")]
        [StringLength(1)]
        public string CveCalculo { get; set; }
        [Required]
        [Column("id_tipo_iva")]
        [StringLength(2)]
        public string IdTipoIva { get; set; }
        [Column("cve_reexped_terceros", TypeName = "numeric(1, 0)")]
        public decimal CveReexpedTerceros { get; set; }
        [Column("cve_valor_agregado", TypeName = "numeric(1, 0)")]
        public decimal CveValorAgregado { get; set; }
        [Column("cve_recargos", TypeName = "numeric(1, 0)")]
        public decimal CveRecargos { get; set; }
        [Column("cve_descargas", TypeName = "numeric(1, 0)")]
        public decimal CveDescargas { get; set; }
        [Column("cve_almacen_fiscal", TypeName = "numeric(1, 0)")]
        public decimal CveAlmacenFiscal { get; set; }
        [Column("tlc")]
        [StringLength(1)]
        public string Tlc { get; set; }
        [Column("actualizar_dta")]
        [StringLength(1)]
        public string ActualizarDta { get; set; }
        [Column("cve_regimen")]
        [StringLength(3)]
        public string CveRegimen { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cuota_fija", TypeName = "decimal(18, 0)")]
        public decimal? CuotaFija { get; set; }
        [Column("aviso_economia")]
        [StringLength(1)]
        public string AvisoEconomia { get; set; }
        [Column("marca_registrada")]
        [StringLength(1)]
        public string MarcaRegistrada { get; set; }
        [Column("immex")]
        [StringLength(1)]
        public string Immex { get; set; }
        [Column("regla_octava")]
        [StringLength(1)]
        public string ReglaOctava { get; set; }
        [Column("precio_estimado")]
        [StringLength(1)]
        public string PrecioEstimado { get; set; }

        [ForeignKey(nameof(IdTipoIva))]
        [InverseProperty(nameof(FtipoIva.Fregimen))]
        public virtual FtipoIva IdTipoIvaNavigation { get; set; }
        [ForeignKey(nameof(IdTipoRegimen))]
        [InverseProperty(nameof(FtipoRegiman.Fregimen))]
        public virtual FtipoRegiman IdTipoRegimenNavigation { get; set; }
        [InverseProperty(nameof(FrelImpRegPago.Fregiman))]
        public virtual ICollection<FrelImpRegPago> FrelImpRegPagos { get; set; }
        [InverseProperty(nameof(FrelPermReg.Fregiman))]
        public virtual ICollection<FrelPermReg> FrelPermRegs { get; set; }
        [InverseProperty(nameof(FrelTipoPedimentoRegiman.Fregiman))]
        public virtual ICollection<FrelTipoPedimentoRegiman> FrelTipoPedimentoRegimen { get; set; }
    }
}
