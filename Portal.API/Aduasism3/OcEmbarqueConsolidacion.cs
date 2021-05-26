using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque_consolidacion")]
    public partial class OcEmbarqueConsolidacion
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_consolidacion")]
        [StringLength(10)]
        public string IdConsolidacion { get; set; }
        [Required]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Column("secuencial_vehiculo")]
        public short SecuencialVehiculo { get; set; }
        [Column("cargado")]
        public bool Cargado { get; set; }
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
