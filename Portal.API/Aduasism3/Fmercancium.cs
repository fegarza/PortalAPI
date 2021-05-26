using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmercancia")]
    [Index(nameof(Rowguid), Name = "index_1701581100", IsUnique = true)]
    public partial class Fmercancium
    {
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("num_vehiculo")]
        [StringLength(20)]
        public string NumVehiculo { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Key]
        [Column("id_docto_origen")]
        [StringLength(10)]
        public string IdDoctoOrigen { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
    }
}
