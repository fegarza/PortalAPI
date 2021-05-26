using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_honorario")]
    public partial class FfgHonorario
    {
        [Key]
        [Column("id_tabulador_hon")]
        [StringLength(3)]
        public string IdTabuladorHon { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(40)]
        public string Descripcion { get; set; }
        [Key]
        [Column("limite_superior", TypeName = "numeric(9, 0)")]
        public decimal LimiteSuperior { get; set; }
        [Required]
        [Column("id_unidad_facturacion")]
        [StringLength(4)]
        public string IdUnidadFacturacion { get; set; }
        [Required]
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
        [Column("minimo_imp", TypeName = "numeric(12, 2)")]
        public decimal? MinimoImp { get; set; }
        [Column("minimo_exp", TypeName = "numeric(12, 2)")]
        public decimal? MinimoExp { get; set; }
        [Column("porcen_imp", TypeName = "decimal(7, 4)")]
        public decimal? PorcenImp { get; set; }
        [Column("porcen_exp", TypeName = "numeric(7, 4)")]
        public decimal? PorcenExp { get; set; }
        [Column("cuenta_conta")]
        [StringLength(14)]
        public string CuentaConta { get; set; }
        [Column("calculo")]
        [StringLength(3)]
        public string Calculo { get; set; }
        [Column("id_tipo_calculo")]
        [StringLength(3)]
        public string IdTipoCalculo { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("maximo_imp", TypeName = "numeric(12, 2)")]
        public decimal? MaximoImp { get; set; }
        [Column("maximo_exp", TypeName = "numeric(12, 2)")]
        public decimal? MaximoExp { get; set; }
        [Column("monto_x_caja", TypeName = "numeric(12, 0)")]
        public decimal? MontoXCaja { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("bh_diferencia_impuestos")]
        public bool? BhDiferenciaImpuestos { get; set; }
        [Column("bh_valor_aduana_comercial")]
        public bool? BhValorAduanaComercial { get; set; }
        [Column("bh_otros_phcc")]
        public bool? BhOtrosPhcc { get; set; }
        [Column("bh_gastos_comprobados")]
        public bool? BhGastosComprobados { get; set; }
        [Column("bh_gastos_complementarios")]
        public bool? BhGastosComplementarios { get; set; }
        [Column("valor_normal")]
        public byte? ValorNormal { get; set; }
        [Column("criterio_facturas")]
        public bool? CriterioFacturas { get; set; }
        [Column("facturas_libres", TypeName = "numeric(5, 0)")]
        public decimal? FacturasLibres { get; set; }
        [Column("monto_facturas", TypeName = "decimal(16, 2)")]
        public decimal? MontoFacturas { get; set; }
        [Column("criterio_fracciones")]
        public bool? CriterioFracciones { get; set; }
        [Column("fracciones_libres", TypeName = "numeric(5, 0)")]
        public decimal? FraccionesLibres { get; set; }
        [Column("monto_fracciones", TypeName = "decimal(16, 2)")]
        public decimal? MontoFracciones { get; set; }
        [Column("criterio_pedimentos")]
        public bool? CriterioPedimentos { get; set; }
        [Column("pedimentos_libres", TypeName = "numeric(5, 0)")]
        public decimal? PedimentosLibres { get; set; }
        [Column("monto_pedimentos", TypeName = "decimal(16, 2)")]
        public decimal? MontoPedimentos { get; set; }
    }
}
