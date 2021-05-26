using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_paqueteria_guia")]
    public partial class OcPaqueteriaGuium
    {
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("no_control_guia")]
        [StringLength(8)]
        public string NoControlGuia { get; set; }
        [Key]
        [Column("guia")]
        [StringLength(35)]
        public string Guia { get; set; }
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("fecha_asociacionRec", TypeName = "datetime")]
        public DateTime? FechaAsociacionRec { get; set; }
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
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("urgente")]
        public bool? Urgente { get; set; }
        [Column("fecha", TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [Column("servicio_critico")]
        public bool? ServicioCritico { get; set; }
        [Column("servicio_especial")]
        public bool? ServicioEspecial { get; set; }
        [Column("servicio_transporte")]
        public bool? ServicioTransporte { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("empleado")]
        [StringLength(6)]
        public string Empleado { get; set; }
        [Column("fecha_inicio_descarga", TypeName = "datetime")]
        public DateTime? FechaInicioDescarga { get; set; }
        [Column("fecha_fin_descarga", TypeName = "datetime")]
        public DateTime? FechaFinDescarga { get; set; }
        [Column("usuario_inicio_descarga")]
        [StringLength(6)]
        public string UsuarioInicioDescarga { get; set; }
        [Column("usuario_fin_descarga")]
        [StringLength(6)]
        public string UsuarioFinDescarga { get; set; }
        [Column("observaciones")]
        [StringLength(100)]
        public string Observaciones { get; set; }
        [Column("danado")]
        public bool Danado { get; set; }
        [Column("empaque_danado")]
        public bool EmpaqueDanado { get; set; }
        [Column("reempacado")]
        public bool Reempacado { get; set; }
        [Column("guia_corta")]
        [StringLength(35)]
        public string GuiaCorta { get; set; }
    }
}
