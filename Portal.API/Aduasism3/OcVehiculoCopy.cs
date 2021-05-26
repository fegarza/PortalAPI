using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_vehiculo_copy")]
    public partial class OcVehiculoCopy
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
        [Column("id_transfer")]
        [StringLength(4)]
        public string IdTransfer { get; set; }
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
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("secuencial_vehiculo")]
        public short? SecuencialVehiculo { get; set; }
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
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("consolidado")]
        public bool Consolidado { get; set; }
        [Column("cargado")]
        public bool Cargado { get; set; }
        [Column("codigo_vehiculo")]
        [StringLength(50)]
        public string CodigoVehiculo { get; set; }
        [Column("id_transfer_salida")]
        [StringLength(4)]
        public string IdTransferSalida { get; set; }
        [Column("chofer")]
        [StringLength(30)]
        public string Chofer { get; set; }
        [Column("licencia")]
        [StringLength(30)]
        public string Licencia { get; set; }
        [Column("truck_number")]
        [StringLength(20)]
        public string TruckNumber { get; set; }
        [Column("cargado_salida")]
        public bool CargadoSalida { get; set; }
        [Column("sello_1")]
        [StringLength(21)]
        public string Sello1 { get; set; }
        [Column("sello_2")]
        [StringLength(21)]
        public string Sello2 { get; set; }
        [Column("id_tipo_movimiento")]
        public short? IdTipoMovimiento { get; set; }
        [Column("estado_placas")]
        [StringLength(40)]
        public string EstadoPlacas { get; set; }
        [Column("transfer")]
        [StringLength(40)]
        public string Transfer { get; set; }
    }
}
