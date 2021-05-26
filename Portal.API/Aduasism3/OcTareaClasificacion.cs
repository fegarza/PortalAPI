using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tarea_clasificacion")]
    public partial class OcTareaClasificacion
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("numero_solicitud")]
        [StringLength(20)]
        public string NumeroSolicitud { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("fecha_requerimiento", TypeName = "datetime")]
        public DateTime FechaRequerimiento { get; set; }
        [Column("fecha_compromiso", TypeName = "datetime")]
        public DateTime FechaCompromiso { get; set; }
        [Column("cantidad_productos")]
        public int CantidadProductos { get; set; }
        [Column("documentos_adjuntos")]
        public bool? DocumentosAdjuntos { get; set; }
        [Column("observaciones")]
        public string Observaciones { get; set; }
        [Column("cancelada")]
        public bool? Cancelada { get; set; }
        [Column("fecha_cancelacion", TypeName = "datetime")]
        public DateTime? FechaCancelacion { get; set; }
        [Column("alerta")]
        public bool? Alerta { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("observaciones_clasificador")]
        public string ObservacionesClasificador { get; set; }
        [Column("finalizado")]
        public bool? Finalizado { get; set; }
    }
}
