using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_dtabulador")]
    public partial class FfgDtabulador
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Key]
        [Column("mex_ame")]
        [StringLength(1)]
        public string MexAme { get; set; }
        [Key]
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Required]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("limite_superior", TypeName = "numeric(10, 0)")]
        public decimal? LimiteSuperior { get; set; }
        [Column("peso_valor")]
        [StringLength(1)]
        public string PesoValor { get; set; }
        [Column("minimo_exp", TypeName = "numeric(12, 2)")]
        public decimal? MinimoExp { get; set; }
        [Column("minimo_imp", TypeName = "numeric(12, 2)")]
        public decimal? MinimoImp { get; set; }
        [Column("porcen_exp", TypeName = "numeric(5, 2)")]
        public decimal? PorcenExp { get; set; }
        [Column("porcen_imp", TypeName = "numeric(5, 2)")]
        public decimal? PorcenImp { get; set; }
        [Required]
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
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("aduana")]
        [StringLength(2)]
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
    }
}
