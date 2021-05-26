using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fconsolida_facturas_carga")]
    public partial class FconsolidaFacturasCarga
    {
        [Key]
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(18, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("valor_comercial", TypeName = "numeric(18, 0)")]
        public decimal? ValorComercial { get; set; }
        [Column("cantidad", TypeName = "numeric(18, 0)")]
        public decimal? Cantidad { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("fecha_emision", TypeName = "datetime")]
        public DateTime? FechaEmision { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("id_agente")]
        [StringLength(6)]
        public string IdAgente { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("consecutivo_original", TypeName = "numeric(18, 0)")]
        public decimal? ConsecutivoOriginal { get; set; }
        [Column("CAAT")]
        [StringLength(6)]
        public string Caat { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("contenedor1")]
        [StringLength(20)]
        public string Contenedor1 { get; set; }
        [Column("contenedor2")]
        [StringLength(20)]
        public string Contenedor2 { get; set; }
        [Column("contenedor3")]
        [StringLength(20)]
        public string Contenedor3 { get; set; }
        [Column("contenedor4")]
        [StringLength(20)]
        public string Contenedor4 { get; set; }
    }
}
