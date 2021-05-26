using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_asn_encabezado")]
    public partial class OcAsnEncabezado
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("asn")]
        [StringLength(15)]
        public string Asn { get; set; }
        [Column("asn_proveedor")]
        [StringLength(10)]
        public string AsnProveedor { get; set; }
        [Column("fecha_asn", TypeName = "datetime")]
        public DateTime FechaAsn { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Column("cantidad_bultos", TypeName = "numeric(5, 0)")]
        public decimal CantidadBultos { get; set; }
        [Column("peso_bultos", TypeName = "decimal(14, 3)")]
        public decimal PesoBultos { get; set; }
        [Required]
        [Column("unidad_peso")]
        [StringLength(3)]
        public string UnidadPeso { get; set; }
        [Column("tipo_carga")]
        [StringLength(2)]
        public string TipoCarga { get; set; }
        [Required]
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("sello1")]
        [StringLength(20)]
        public string Sello1 { get; set; }
        [Column("sello2")]
        [StringLength(20)]
        public string Sello2 { get; set; }
        [Column("tipo_transporte")]
        [StringLength(1)]
        public string TipoTransporte { get; set; }
        [Column("guia")]
        [StringLength(35)]
        public string Guia { get; set; }
        [Column("fecha_guia", TypeName = "datetime")]
        public DateTime? FechaGuia { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("incoterm")]
        [StringLength(4)]
        public string Incoterm { get; set; }
        [Column("id_bodega")]
        [StringLength(4)]
        public string IdBodega { get; set; }
        [Column("id_destino_final")]
        [StringLength(4)]
        public string IdDestinoFinal { get; set; }
        [Column("status_asn")]
        public short StatusAsn { get; set; }
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
    }
}
