using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdestino_final_light")]
    public partial class FdestinoFinalLight
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
        [StringLength(3)]
        public string IdDestino { get; set; }
        [Column("id_tipo_org")]
        [StringLength(2)]
        public string IdTipoOrg { get; set; }
        [Column("id_organizacion")]
        [StringLength(8)]
        public string IdOrganizacion { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("fecha_hora", TypeName = "datetime")]
        public DateTime? FechaHora { get; set; }
        [Column("id_linea_flete_transfer")]
        [StringLength(4)]
        public string IdLineaFleteTransfer { get; set; }
    }
}
