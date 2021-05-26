using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fmercancia_log")]
    public partial class FmercanciaLog
    {
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Column("id_docto_origen")]
        [StringLength(10)]
        public string IdDoctoOrigen { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("accion")]
        [StringLength(1)]
        public string Accion { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("usuario")]
        [StringLength(256)]
        public string Usuario { get; set; }
        [Column("direccion")]
        [StringLength(256)]
        public string Direccion { get; set; }
    }
}
