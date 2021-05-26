using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_usuact_detalle")]
    [Index(nameof(Rowguid), Name = "index_1438628168", IsUnique = true)]
    public partial class FrelUsuactDetalle
    {
        [Key]
        [Column("id_docto_origen_usuact")]
        [StringLength(10)]
        public string IdDoctoOrigenUsuact { get; set; }
        [Key]
        [Column("no_sec_usuact", TypeName = "numeric(3, 0)")]
        public decimal NoSecUsuact { get; set; }
        [Required]
        [Column("id_actividad")]
        [StringLength(6)]
        public string IdActividad { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_actividad", TypeName = "datetime")]
        public DateTime FechaActividad { get; set; }
        [Key]
        [Column("id_proceso")]
        [StringLength(2)]
        public string IdProceso { get; set; }
        [Column("no_poliza")]
        [StringLength(11)]
        public string NoPoliza { get; set; }
        [Column("importe_poliza", TypeName = "numeric(10, 2)")]
        public decimal? ImportePoliza { get; set; }
        [Column("observaciones")]
        [StringLength(100)]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("proveedor")]
        [StringLength(40)]
        public string Proveedor { get; set; }
        [Column("num_tracking")]
        [StringLength(15)]
        public string NumTracking { get; set; }
        [Column("id_pre_cuenta_ame")]
        [StringLength(10)]
        public string IdPreCuentaAme { get; set; }
        [Column("id_factura_ame")]
        [StringLength(10)]
        public string IdFacturaAme { get; set; }
        [Column("costo_venta", TypeName = "numeric(12, 2)")]
        public decimal? CostoVenta { get; set; }
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal? Cantidad { get; set; }

        [ForeignKey(nameof(IdActividad))]
        [InverseProperty(nameof(Factividad.FrelUsuactDetalles))]
        public virtual Factividad IdActividadNavigation { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Fusuario.FrelUsuactDetalles))]
        public virtual Fusuario IdUsuarioNavigation { get; set; }
    }
}
