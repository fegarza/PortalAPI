using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprofepa_documento")]
    [Index(nameof(Rowguid), Name = "index_477296810", IsUnique = true)]
    public partial class FprofepaDocumento
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(5, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumSecuencial { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Required]
        [Column("tipo_documento")]
        [StringLength(2)]
        public string TipoDocumento { get; set; }
        [Required]
        [Column("certificado")]
        [StringLength(12)]
        public string Certificado { get; set; }
        [Required]
        [Column("entidad_certificado")]
        [StringLength(3)]
        public string EntidadCertificado { get; set; }
        [Column("fecha_expedicion", TypeName = "datetime")]
        public DateTime? FechaExpedicion { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        [Column("monto_autorizado", TypeName = "decimal(15, 2)")]
        public decimal? MontoAutorizado { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
