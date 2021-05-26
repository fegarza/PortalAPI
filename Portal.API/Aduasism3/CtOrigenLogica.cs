using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ct_origen_logica")]
    public partial class CtOrigenLogica
    {
        [Key]
        [Column("cve_poliza", TypeName = "decimal(4, 0)")]
        public decimal CvePoliza { get; set; }
        [Key]
        [Column("numero_detalle", TypeName = "decimal(1, 0)")]
        public decimal NumeroDetalle { get; set; }
        [Required]
        [Column("archivo_fuente")]
        [StringLength(255)]
        public string ArchivoFuente { get; set; }
        [Required]
        [Column("seleccion")]
        [StringLength(255)]
        public string Seleccion { get; set; }
        [Required]
        [Column("campo_contable")]
        [StringLength(255)]
        public string CampoContable { get; set; }
        [Required]
        [Column("campo_empresa")]
        [StringLength(255)]
        public string CampoEmpresa { get; set; }
        [Required]
        [Column("campo_fecha_contab")]
        [StringLength(255)]
        public string CampoFechaContab { get; set; }
        [Key]
        [Column("clave_detalle", TypeName = "decimal(1, 0)")]
        public decimal ClaveDetalle { get; set; }
        [Column("archivo_auxiliar_b")]
        [StringLength(255)]
        public string ArchivoAuxiliarB { get; set; }
        [Column("archivo_auxiliar_c")]
        [StringLength(255)]
        public string ArchivoAuxiliarC { get; set; }
        [Column("agrupar_por")]
        [StringLength(1)]
        public string AgruparPor { get; set; }
        [Column("texto_ref")]
        [StringLength(255)]
        public string TextoRef { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("status_origen")]
        [StringLength(1)]
        public string StatusOrigen { get; set; }
        [Column("seleccion_b")]
        [StringLength(255)]
        public string SeleccionB { get; set; }
        [Column("condicion_b")]
        [StringLength(255)]
        public string CondicionB { get; set; }
        [Column("condicion")]
        [StringLength(250)]
        public string Condicion { get; set; }
        [Column("seleccion_c")]
        [StringLength(255)]
        public string SeleccionC { get; set; }
        [Column("condicion_c")]
        [StringLength(255)]
        public string CondicionC { get; set; }
        [Column("condicion_status")]
        [StringLength(255)]
        public string CondicionStatus { get; set; }
        [Column("campo_poliza")]
        [StringLength(255)]
        public string CampoPoliza { get; set; }
        [Column("campo_periodo")]
        [StringLength(255)]
        public string CampoPeriodo { get; set; }
        [Column("campo_consecutivo")]
        [StringLength(255)]
        public string CampoConsecutivo { get; set; }
    }
}
