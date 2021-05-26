using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdestino_final")]
    [Index(nameof(Rowguid), Name = "index_661577395", IsUnique = true)]
    public partial class FdestinoFinal
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
        [Required]
        [Column("entregado_por")]
        [StringLength(48)]
        public string EntregadoPor { get; set; }
        [Column("guia_flete")]
        [StringLength(20)]
        public string GuiaFlete { get; set; }
        [Column("entregado_a")]
        [StringLength(30)]
        public string EntregadoA { get; set; }
        [Column("fecha_hora", TypeName = "datetime")]
        public DateTime? FechaHora { get; set; }
        [Column("doble_operador")]
        [StringLength(1)]
        public string DobleOperador { get; set; }
        [Column("flete_x_cobrar")]
        [StringLength(1)]
        public string FleteXCobrar { get; set; }
        [Column("importe", TypeName = "numeric(11, 2)")]
        public decimal? Importe { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("facturar_a", TypeName = "text")]
        public string FacturarA { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("obs_destino", TypeName = "text")]
        public string ObsDestino { get; set; }
        [Column("tipo_factura")]
        [StringLength(1)]
        public string TipoFactura { get; set; }
        [Column("id_linea_ame")]
        [StringLength(4)]
        public string IdLineaAme { get; set; }
    }
}
