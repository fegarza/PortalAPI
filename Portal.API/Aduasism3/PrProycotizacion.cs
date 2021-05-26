using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("pr_proycotizacion")]
    public partial class PrProycotizacion
    {
        [Key]
        [Column("cveproy")]
        [StringLength(20)]
        public string Cveproy { get; set; }
        [Key]
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Key]
        [Column("indcte")]
        [StringLength(20)]
        public string Indcte { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(255)]
        public string Nombre { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Column("cve_cliente")]
        [StringLength(10)]
        public string CveCliente { get; set; }
        [Column("tipo_proyecto")]
        public int? TipoProyecto { get; set; }
        [Column("ubicacion")]
        public int? Ubicacion { get; set; }
        [Column("fecha_inicio", TypeName = "datetime")]
        public DateTime? FechaInicio { get; set; }
        [Column("fecha_terminacion", TypeName = "datetime")]
        public DateTime? FechaTerminacion { get; set; }
        [Column("estado")]
        public int? Estado { get; set; }
        [Column("zona_economica")]
        [StringLength(5)]
        public string ZonaEconomica { get; set; }
        [Column("reg_imss")]
        [StringLength(10)]
        public string RegImss { get; set; }
        [Column("fondo", TypeName = "decimal(10, 4)")]
        public decimal? Fondo { get; set; }
        [Column("empr_responsable")]
        public int? EmprResponsable { get; set; }
        [Column("empl_responsable")]
        [StringLength(10)]
        public string EmplResponsable { get; set; }
        [Column("cve_contrato")]
        [StringLength(10)]
        public string CveContrato { get; set; }
        [Column("cve_concurso")]
        [StringLength(10)]
        public string CveConcurso { get; set; }
        [Column("fianza", TypeName = "decimal(10, 4)")]
        public decimal? Fianza { get; set; }
        [Column("fsr", TypeName = "decimal(5, 4)")]
        public decimal? Fsr { get; set; }
        [Column("fsrm", TypeName = "decimal(5, 4)")]
        public decimal? Fsrm { get; set; }
        [Column("poravance", TypeName = "decimal(2, 2)")]
        public decimal? Poravance { get; set; }
        [Column("proyborrado")]
        public int Proyborrado { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("por_ind_uti", TypeName = "decimal(12, 4)")]
        public decimal? PorIndUti { get; set; }
        [Column("por_indirecto", TypeName = "decimal(12, 4)")]
        public decimal? PorIndirecto { get; set; }
        [Column("por_financiamiento", TypeName = "decimal(12, 4)")]
        public decimal? PorFinanciamiento { get; set; }
        [Column("por_utilidad", TypeName = "decimal(12, 4)")]
        public decimal? PorUtilidad { get; set; }
        [Column("por_herramienta_m", TypeName = "decimal(12, 4)")]
        public decimal? PorHerramientaM { get; set; }
        [Column("por_maquinaria_m", TypeName = "decimal(12, 4)")]
        public decimal? PorMaquinariaM { get; set; }
        [Column("salario_minimo", TypeName = "decimal(12, 4)")]
        public decimal? SalarioMinimo { get; set; }
        [Column("no_tabulador")]
        public int? NoTabulador { get; set; }
        [Column("wbs")]
        [StringLength(200)]
        public string Wbs { get; set; }
        [Column("monto", TypeName = "decimal(16, 4)")]
        public decimal? Monto { get; set; }
        [Column("nivel_adm")]
        public int? NivelAdm { get; set; }
        [Column("wbs_automatico")]
        public int? WbsAutomatico { get; set; }
        [Column("autorizado")]
        public int? Autorizado { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("monto_i", TypeName = "decimal(16, 4)")]
        public decimal? MontoI { get; set; }
        [Column("monto_r", TypeName = "decimal(16, 4)")]
        public decimal? MontoR { get; set; }
        [Column("monto_v", TypeName = "decimal(16, 4)")]
        public decimal? MontoV { get; set; }
        [Column("wbs_pemex")]
        [StringLength(1)]
        public string WbsPemex { get; set; }
        [Column("status_admin")]
        [StringLength(1)]
        public string StatusAdmin { get; set; }
    }
}
