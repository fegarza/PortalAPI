using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsolicitud_ffrr")]
    [Index(nameof(Rowguid), Name = "index_450100644", IsUnique = true)]
    public partial class FsolicitudFfrr
    {
        [Key]
        [Column("id_solicitud")]
        [StringLength(10)]
        public string IdSolicitud { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Required]
        [Column("tipo_servicio")]
        [StringLength(1)]
        public string TipoServicio { get; set; }
        [Required]
        [Column("clase_trafico")]
        [StringLength(1)]
        public string ClaseTrafico { get; set; }
        [Required]
        [Column("condiciones_pago")]
        [StringLength(1)]
        public string CondicionesPago { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_escape")]
        public int IdEscape { get; set; }
        [Required]
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("instruccion_manejo")]
        [StringLength(100)]
        public string InstruccionManejo { get; set; }
        [Column("descripcion_flete")]
        [StringLength(100)]
        public string DescripcionFlete { get; set; }
        [Required]
        [Column("descripcion_clasificacion")]
        [StringLength(70)]
        public string DescripcionClasificacion { get; set; }
        [Required]
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Column("stcc")]
        [StringLength(10)]
        public string Stcc { get; set; }
        [Required]
        [Column("id_cliente_factura")]
        [StringLength(6)]
        public string IdClienteFactura { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
