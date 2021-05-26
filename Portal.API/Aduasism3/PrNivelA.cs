using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_nivel_a")]
    public partial class PrNivelA
    {
        [Key]
        [Column("cvenivel")]
        [StringLength(20)]
        public string Cvenivel { get; set; }
        [Key]
        [Column("cverelacion")]
        [StringLength(20)]
        public string Cverelacion { get; set; }
        [Key]
        [Column("indcte")]
        [StringLength(20)]
        public string Indcte { get; set; }
        [Column("wbs")]
        [StringLength(150)]
        public string Wbs { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Column("tipo_nivel")]
        public int? TipoNivel { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("fecha_terminacion", TypeName = "datetime")]
        public DateTime? FechaTerminacion { get; set; }
        [Column("empl_responsable")]
        [StringLength(10)]
        public string EmplResponsable { get; set; }
        [Column("empr_responsable")]
        public int? EmprResponsable { get; set; }
        [Column("monto", TypeName = "decimal(16, 4)")]
        public decimal? Monto { get; set; }
        [Column("moneda")]
        [StringLength(5)]
        public string Moneda { get; set; }
        [Column("montoext", TypeName = "decimal(16, 4)")]
        public decimal? Montoext { get; set; }
        [Column("fsr", TypeName = "decimal(5, 4)")]
        public decimal? Fsr { get; set; }
        [Column("fsrm", TypeName = "decimal(5, 4)")]
        public decimal? Fsrm { get; set; }
        [Column("por_financiamiento", TypeName = "decimal(5, 4)")]
        public decimal? PorFinanciamiento { get; set; }
        [Column("por_indirectos", TypeName = "decimal(5, 4)")]
        public decimal? PorIndirectos { get; set; }
        [Column("por_utilidad", TypeName = "decimal(5, 4)")]
        public decimal? PorUtilidad { get; set; }
        [Column("por_herramienta_m", TypeName = "decimal(5, 4)")]
        public decimal? PorHerramientaM { get; set; }
        [Column("por_maquinaria_m", TypeName = "decimal(5, 4)")]
        public decimal? PorMaquinariaM { get; set; }
        [Column("por_integracion", TypeName = "decimal(2, 2)")]
        public decimal? PorIntegracion { get; set; }
        [Column("por_avance", TypeName = "decimal(2, 2)")]
        public decimal? PorAvance { get; set; }
        [Column("zona_economica")]
        [StringLength(5)]
        public string ZonaEconomica { get; set; }
        [Column("no_tabulador")]
        public int? NoTabulador { get; set; }
        [Column("estado")]
        public int? Estado { get; set; }
        [Column("fianza", TypeName = "decimal(12, 4)")]
        public decimal? Fianza { get; set; }
        [Column("costo_directo", TypeName = "decimal(12, 4)")]
        public decimal? CostoDirecto { get; set; }
        [Column("imp_directo", TypeName = "decimal(12, 4)")]
        public decimal? ImpDirecto { get; set; }
        [Column("imp_financiamiento", TypeName = "decimal(12, 4)")]
        public decimal? ImpFinanciamiento { get; set; }
        [Column("imp_indirecto", TypeName = "decimal(12, 4)")]
        public decimal? ImpIndirecto { get; set; }
        [Column("imp_utilidad", TypeName = "decimal(12, 4)")]
        public decimal? ImpUtilidad { get; set; }
        [Column("nivel_borrado")]
        public int? NivelBorrado { get; set; }
        [Column("autorizado")]
        public int Autorizado { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("next_nivel")]
        public int? NextNivel { get; set; }
        [Column("usuario")]
        [StringLength(10)]
        public string Usuario { get; set; }
        [Column("salario_minimo", TypeName = "decimal(12, 4)")]
        public decimal? SalarioMinimo { get; set; }
    }
}
