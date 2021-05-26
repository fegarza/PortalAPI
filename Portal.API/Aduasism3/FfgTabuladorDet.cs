using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_tabulador_det")]
    public partial class FfgTabuladorDet
    {
        [Required]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Required]
        [Column("mex_ame")]
        [StringLength(1)]
        public string MexAme { get; set; }
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal? NumDetalle { get; set; }
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("limite_superior", TypeName = "numeric(10, 0)")]
        public decimal? LimiteSuperior { get; set; }
        [Column("minimo_exp", TypeName = "decimal(14, 2)")]
        public decimal? MinimoExp { get; set; }
        [Column("minimo_imp", TypeName = "decimal(14, 2)")]
        public decimal? MinimoImp { get; set; }
        [Column("calculo")]
        [StringLength(1)]
        public string Calculo { get; set; }
        [Column("id_tipo_calculo")]
        [StringLength(3)]
        public string IdTipoCalculo { get; set; }
        [Column("id_unidad_facturacion")]
        [StringLength(4)]
        public string IdUnidadFacturacion { get; set; }
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
        [Column("porcen_imp", TypeName = "numeric(7, 0)")]
        public decimal? PorcenImp { get; set; }
        [Column("porcen_exp", TypeName = "numeric(7, 0)")]
        public decimal? PorcenExp { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("aduana")]
        [StringLength(255)]
        public string Aduana { get; set; }
        [Column("aduana_check")]
        [StringLength(1)]
        public string AduanaCheck { get; set; }
        [Column("aduana_razon_social")]
        [StringLength(40)]
        public string AduanaRazonSocial { get; set; }
        [Column("auto_gts_compl")]
        [StringLength(1)]
        public string AutoGtsCompl { get; set; }
        [Column("maximo_exp", TypeName = "numeric(14, 0)")]
        public decimal? MaximoExp { get; set; }
        [Column("maximo_imp", TypeName = "numeric(14, 0)")]
        public decimal? MaximoImp { get; set; }
        [Column("desc_2")]
        [StringLength(255)]
        public string Desc2 { get; set; }
        [Column("limite_inferior_impo", TypeName = "numeric(14, 4)")]
        public decimal? LimiteInferiorImpo { get; set; }
        [Column("limite_inferior_expo", TypeName = "numeric(14, 4)")]
        public decimal? LimiteInferiorExpo { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
        [Column("aplica_semaforo")]
        [StringLength(1)]
        public string AplicaSemaforo { get; set; }
        [Column("monto_verde_imp", TypeName = "numeric(18, 0)")]
        public decimal? MontoVerdeImp { get; set; }
        [Column("monto_verde_exp", TypeName = "numeric(18, 0)")]
        public decimal? MontoVerdeExp { get; set; }
        [Column("porcen_comisionista", TypeName = "decimal(18, 0)")]
        public decimal? PorcenComisionista { get; set; }
        [Column("porcen_corresponsal", TypeName = "decimal(18, 0)")]
        public decimal? PorcenCorresponsal { get; set; }
        [Column("costo_venta", TypeName = "decimal(18, 0)")]
        public decimal? CostoVenta { get; set; }
        [Column("costo_venta_exp", TypeName = "decimal(18, 0)")]
        public decimal? CostoVentaExp { get; set; }
        [Column("monto_dlls", TypeName = "decimal(14, 2)")]
        public decimal? MontoDlls { get; set; }
    }
}
