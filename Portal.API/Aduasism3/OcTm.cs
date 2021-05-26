using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_tms")]
    public partial class OcTm
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_embarque")]
        [StringLength(15)]
        public string IdEmbarque { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("fecha_recoleccion", TypeName = "datetime")]
        public DateTime FechaRecoleccion { get; set; }
        [Column("fecha_entrega", TypeName = "datetime")]
        public DateTime? FechaEntrega { get; set; }
        [Required]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("haz_mat")]
        public bool HazMat { get; set; }
        [Column("urgente")]
        public bool Urgente { get; set; }
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Column("referencia_cliente")]
        [StringLength(36)]
        public string ReferenciaCliente { get; set; }
        [Required]
        [Column("numero_guia")]
        [StringLength(35)]
        public string NumeroGuia { get; set; }
        [Column("bultos")]
        public int Bultos { get; set; }
        [Required]
        [Column("tipo_bulto")]
        [StringLength(5)]
        public string TipoBulto { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("importe_flete", TypeName = "decimal(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Required]
        [Column("moneda_flete")]
        [StringLength(4)]
        public string MonedaFlete { get; set; }
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
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
        [Column("me_number")]
        [StringLength(15)]
        public string MeNumber { get; set; }
    }
}
