using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_vehiculo_cargado")]
    public partial class OcVehiculoCargado
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Key]
        [Column("fecha_arribo", TypeName = "datetime")]
        public DateTime FechaArribo { get; set; }
        [Required]
        [Column("id_tipo_operacion")]
        [StringLength(1)]
        public string IdTipoOperacion { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_localizacion")]
        [StringLength(15)]
        public string IdLocalizacion { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("placas")]
        [StringLength(20)]
        public string Placas { get; set; }
        [Column("observaciones")]
        public string Observaciones { get; set; }
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("id_status_vehiculo")]
        public short IdStatusVehiculo { get; set; }
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
    }
}
