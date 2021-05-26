using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque_bulto")]
    public partial class OcEmbarqueBulto
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("id_instruccion")]
        [StringLength(10)]
        public string IdInstruccion { get; set; }
        [Key]
        [Column("id_recibo_guia")]
        [StringLength(10)]
        public string IdReciboGuia { get; set; }
        [Key]
        [Column("secuencial_guia")]
        public short SecuencialGuia { get; set; }
        [Key]
        [Column("secuencial_bulto")]
        public short SecuencialBulto { get; set; }
        [Required]
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
        [Column("cantidad_bulto")]
        public int CantidadBulto { get; set; }
        [Column("no_pallet")]
        public int? NoPallet { get; set; }
        [Column("cargado")]
        public bool Cargado { get; set; }
        [Column("usuario_carga")]
        [StringLength(6)]
        public string UsuarioCarga { get; set; }
        [Column("fecha_carga", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
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
