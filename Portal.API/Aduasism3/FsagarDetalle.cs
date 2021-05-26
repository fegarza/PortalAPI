using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsagar_detalle")]
    [Index(nameof(Rowguid), Name = "index_1947206037", IsUnique = true)]
    public partial class FsagarDetalle
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("secuencial", TypeName = "decimal(4, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("id_fraccion")]
        [StringLength(8)]
        public string IdFraccion { get; set; }
        [Required]
        [Column("descripcion_fraccion")]
        [StringLength(250)]
        public string DescripcionFraccion { get; set; }
        [Column("cantidad_comercial", TypeName = "decimal(14, 3)")]
        public decimal CantidadComercial { get; set; }
        [Required]
        [Column("cve_unidad_comercial")]
        [StringLength(2)]
        public string CveUnidadComercial { get; set; }
        [Required]
        [Column("requisito_sanitario")]
        [StringLength(50)]
        public string RequisitoSanitario { get; set; }
        [Required]
        [Column("certificado_sanitario")]
        [StringLength(8)]
        public string CertificadoSanitario { get; set; }
        [Column("valor_total", TypeName = "decimal(12, 2)")]
        public decimal ValorTotal { get; set; }
        [Column("cantidad_autorizada", TypeName = "decimal(14, 3)")]
        public decimal CantidadAutorizada { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Required]
        [Column("id_pais_vendedor")]
        [StringLength(3)]
        public string IdPaisVendedor { get; set; }
        [Column("planta")]
        [StringLength(13)]
        public string Planta { get; set; }
        [Column("lote")]
        [StringLength(15)]
        public string Lote { get; set; }
        [Column("fecha_sacrificio", TypeName = "datetime")]
        public DateTime? FechaSacrificio { get; set; }
        [Column("fecha_empaque", TypeName = "datetime")]
        public DateTime? FechaEmpaque { get; set; }
        [Column("id_calidad")]
        [StringLength(2)]
        public string IdCalidad { get; set; }
        [Column("cve_unidad_tarifa")]
        [StringLength(2)]
        public string CveUnidadTarifa { get; set; }
        [Column("cantidad_tarifa", TypeName = "decimal(14, 3)")]
        public decimal? CantidadTarifa { get; set; }
        [Column("tipo_requisito")]
        [StringLength(2)]
        public string TipoRequisito { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("may_contain")]
        [StringLength(1)]
        public string MayContain { get; set; }
        [Column("uso_prod")]
        [StringLength(3)]
        public string UsoProd { get; set; }
        [Column("certificado")]
        [StringLength(50)]
        public string Certificado { get; set; }
    }
}
