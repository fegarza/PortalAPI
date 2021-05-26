using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffirma_digital")]
    [Index(nameof(Rowguid), Name = "index_103723472", IsUnique = true)]
    public partial class FfirmaDigital
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("tipo_figura_ped")]
        [StringLength(1)]
        public string TipoFiguraPed { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("firma_pedimento")]
        [StringLength(400)]
        public string FirmaPedimento { get; set; }
        [Column("firma_archivo")]
        [StringLength(250)]
        public string FirmaArchivo { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("ruta_archivo")]
        [StringLength(100)]
        public string RutaArchivo { get; set; }
        [Column("num_serie")]
        [StringLength(30)]
        public string NumSerie { get; set; }
        [Column("id_usuario_gen")]
        [StringLength(6)]
        public string IdUsuarioGen { get; set; }
        [Column("fecha_gen", TypeName = "datetime")]
        public DateTime? FechaGen { get; set; }
        [Column("id_usuario_ult_gen")]
        [StringLength(6)]
        public string IdUsuarioUltGen { get; set; }
        [Column("fecha_ult_gen", TypeName = "datetime")]
        public DateTime? FechaUltGen { get; set; }
        [Column("last_changed", TypeName = "datetime")]
        public DateTime? LastChanged { get; set; }
        [Column("ruta_archivo_banco")]
        [StringLength(250)]
        public string RutaArchivoBanco { get; set; }
        [Column("id_usuario_gen_banco")]
        [StringLength(6)]
        public string IdUsuarioGenBanco { get; set; }
        [Column("fecha_gen_banco", TypeName = "datetime")]
        public DateTime? FechaGenBanco { get; set; }
        [Column("id_usuario_gen_ult_banco")]
        [StringLength(6)]
        public string IdUsuarioGenUltBanco { get; set; }
        [Column("fecha_ult_gen_banco", TypeName = "datetime")]
        public DateTime? FechaUltGenBanco { get; set; }
        [Column("fecha_autorizacion", TypeName = "datetime")]
        public DateTime? FechaAutorizacion { get; set; }
        [Column("id_usuario_autoriza")]
        [StringLength(6)]
        public string IdUsuarioAutoriza { get; set; }
        [Column("fecha_imprime", TypeName = "datetime")]
        public DateTime? FechaImprime { get; set; }
        [Column("fecha_recepcion_validacion", TypeName = "datetime")]
        public DateTime? FechaRecepcionValidacion { get; set; }
        [Column("notificado")]
        [StringLength(1)]
        public string Notificado { get; set; }

        [ForeignKey("IdReferencia,IdRectificacion")]
        [InverseProperty(nameof(Fpedimento.FfirmaDigital))]
        public virtual Fpedimento IdRe { get; set; }
    }
}
