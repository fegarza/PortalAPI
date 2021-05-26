using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_paqueteria_encabezado")]
    public partial class OcPaqueteriaEncabezado
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("no_control_guia")]
        [StringLength(8)]
        public string NoControlGuia { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime FechaGuia { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("recibe")]
        [StringLength(6)]
        public string Recibe { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
        [Column("total_guias")]
        public int TotalGuias { get; set; }
        [Column("cancelado")]
        public bool Cancelado { get; set; }
        [Column("usuario_cancela")]
        [StringLength(6)]
        public string UsuarioCancela { get; set; }
        [Column("fecha_cancela", TypeName = "datetime")]
        public DateTime? FechaCancela { get; set; }
        [Column("id_clase_carga")]
        public short IdClaseCarga { get; set; }
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
        [Column("numero_trailer")]
        [StringLength(20)]
        public string NumeroTrailer { get; set; }
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("id_localizacion")]
        [StringLength(15)]
        public string IdLocalizacion { get; set; }
        [Column("fecha_inicio_carga", TypeName = "date")]
        public DateTime? FechaInicioCarga { get; set; }
        [Column("fecha_fin_carga", TypeName = "date")]
        public DateTime? FechaFinCarga { get; set; }
        [Column("fecha_arribo", TypeName = "datetime")]
        public DateTime? FechaArribo { get; set; }
    }
}
