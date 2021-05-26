using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fshipper")]
    [Index(nameof(Rowguid), Name = "index_418100530", IsUnique = true)]
    public partial class Fshipper
    {
        [Key]
        [Column("id_shipper")]
        [StringLength(8)]
        public string IdShipper { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(10)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Required]
        [Column("id_forwarding")]
        [StringLength(8)]
        public string IdForwarding { get; set; }
        [Column("fecha_exportacion", TypeName = "datetime")]
        public DateTime? FechaExportacion { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("puente")]
        [StringLength(30)]
        public string Puente { get; set; }
        [Required]
        [Column("id_usuario_autoriza")]
        [StringLength(6)]
        public string IdUsuarioAutoriza { get; set; }
        [Required]
        [Column("puesto_que_autoriza")]
        [StringLength(20)]
        public string PuestoQueAutoriza { get; set; }
        [Column("carrier_id_code")]
        [StringLength(15)]
        public string CarrierIdCode { get; set; }
        [Column("ship_refer")]
        [StringLength(15)]
        public string ShipRefer { get; set; }
        [Column("entry_number")]
        [StringLength(15)]
        public string EntryNumber { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
